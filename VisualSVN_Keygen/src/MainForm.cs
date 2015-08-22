using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Security.Cryptography;
using Mono.Cecil;
using System.Diagnostics;

namespace FullO.Keygens.VisualSVN
{
	public partial class MainForm : Form
	{
		const string FILE_TO_PATCH = "VisualSVN.VS.Interface.dll";
		const string NO_FILE_TO_PATCH = "[" + FILE_TO_PATCH + " not found]";

		private License license = new License();


		public MainForm()
		{
			InitializeComponent();
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			RSACryptoServiceProvider rsaProvider = new RSACryptoServiceProvider();
			using (StreamReader stream = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(string.Format("{0}.Keys.private.xml", this.GetType().Namespace))))
			{
				rsaProvider.FromXmlString(stream.ReadToEnd());
				stream.Close();
			}

			RSALicenseCodec codec = new RSALicenseCodec(rsaProvider.ExportParameters(true));
			XorLicenseCodec codec2 = new XorLicenseCodec();
			Deprotector deprotector = new Deprotector(new EncoderSequence(new IEncoder[] { codec, codec2 }));

			txtLicense.Text = FormatKey(deprotector.GenerateLicense(license));
		}

		private string FormatKey(string pureKey)
		{
			int rowLength = 58;

			string row = new string('-', rowLength);
			StringBuilder builder = new StringBuilder(pureKey.Length);
			builder.Append(row);
			builder.AppendLine();
			int startIndex = 0;
			while ((startIndex + rowLength) <= pureKey.Length)
			{
				builder.Append(pureKey.Substring(startIndex, rowLength));
				builder.AppendLine();
				startIndex += rowLength;
			}
			builder.Append(pureKey.Substring(startIndex, pureKey.Length % rowLength));
			builder.AppendLine();
			builder.Append(row);
			return builder.ToString();
		}

		private void btnPatch_Click(object sender, EventArgs e)
		{
			EmbeddedResource publicKeyResource = null;

			AssemblyDefinition assemblyFactory = AssemblyFactory.GetAssembly(txtPath.Text);
			foreach (ModuleDefinition module in assemblyFactory.Modules)
			{
				string moduleName = module.Name.Substring(0, module.Name.LastIndexOf('.'));
				foreach (Resource resource in module.Resources)
				{
					if (resource.Name == string.Format("{0}.public.key", moduleName))
					{
						publicKeyResource = resource as EmbeddedResource;
						break;
					}
				}

				if (publicKeyResource != null)
					break;
			}

			if (publicKeyResource != null)
			{
				StreamReader stream = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(string.Format("{0}.Keys.public.key", this.GetType().Namespace)), Encoding.Default);
				byte[] publicKey = System.Text.ASCIIEncoding.Default.GetBytes(stream.ReadToEnd());
				stream.Close();
				stream.Dispose();

				if (CompareKeys(publicKeyResource.Data, publicKey))
				{
					ShowErrorMessage(string.Format("File '{0}' was already patched.", Path.GetFileName(txtPath.Text)), null);
				}
				else
				{
					if (chkMakeBackup.Checked)
					{
						try
						{
							File.Copy(txtPath.Text, string.Format("{0}.bck", txtPath.Text), true);
						}
						catch (Exception ex)
						{
							ShowErrorMessage(string.Format("Unable to make a backup of '{0}'.", Path.GetFileName(txtPath.Text)), ex);
						}
					}
					
					publicKeyResource.Data = publicKey;

					try
					{
						AssemblyFactory.SaveAssembly(assemblyFactory, txtPath.Text);
					}
					catch (Exception ex)
					{
						ShowErrorMessage(string.Format("Unable to patch file '{0}'.", Path.GetFileName(txtPath.Text)), ex);
					}
				}
			}
			else
			{
				ShowErrorMessage(string.Format("Unable to find public key resource in '{0}'.", Path.GetFileName(txtPath.Text)), null);
			}
		}

		bool CompareKeys(byte[] x, byte[] y)
		{
			if (x.Length != y.Length)
				return false;

			for (int i = 0; i < x.Length; i++)
			{
				if (x[i] != y[i])
					return false;
			}

			return true;
		}

		void ShowErrorMessage(string message, Exception ex)
		{
			if (ex != null)
			{
				message = string.Format("{0}{1}{1}Error message:{1}{2}", message, Environment.NewLine, ex.Message);
			}

			MessageBox.Show(message, this.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			txtPath.Text = NO_FILE_TO_PATCH;
			btnPatch.Enabled = false;

			CheckFileToPatchExists(string.Format(@"{0}\VisualSVN\bin\", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)));

		
			propertyGrid1.SelectedObject = license;
		}

		private void CheckFileToPatchExists(string filepath)
		{
			if (File.Exists(filepath))
			{
				txtPath.Text = filepath;
			}
			else
			{
				string[] files = Directory.GetFiles(Path.GetDirectoryName(filepath), FILE_TO_PATCH, SearchOption.AllDirectories);
				txtPath.Text = (files.Length == 1) ? txtPath.Text = files[0] : NO_FILE_TO_PATCH;
			}
			btnPatch.Enabled = !(txtPath.Text.Equals(NO_FILE_TO_PATCH));
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			openFileDialog.Filter = "File to patch (" + FILE_TO_PATCH + ")|" + FILE_TO_PATCH + "|File to patch (*.dll)|*.dll|All (*.*)|*.*";
			openFileDialog.FilterIndex = 0;
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
			DialogResult result = openFileDialog.ShowDialog(this);
			if (result == DialogResult.OK)
			{
				CheckFileToPatchExists(openFileDialog.FileName);
			}
		}

		private void txtLicense_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.A)
			{
				((TextBox)sender).SelectAll();
			}
		}

		private void linkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				Process.Start(((LinkLabel)sender).Text);
			}
			catch { }
		}
	}
}
