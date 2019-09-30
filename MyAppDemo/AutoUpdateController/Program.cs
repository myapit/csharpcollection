/*
 * Created by SharpDevelop.
 * User: domokun
 * Date: 30/09/2019
 * Time: 2:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Text;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Windows;
using System.IO.Compression;

namespace AutoUpdateController
{
	class Program
	{
		const string remoteVersionURL = "http://ossdev.usm.my/hafiz/program-version.txt";
		
		public static void Main(string[] args)
		{
			checkAppInstance();
			
			Console.WriteLine("Auto Update Controller");
			Console.WriteLine("======================");
			
			while(true)
			{
				Console.WriteLine("[c] - Check for update.");
				Console.WriteLine("[x] - Exit update controller.");
				string keyInput = Console.ReadLine();
				switch(keyInput){
					case "c":
						checkAutoUpdate();
						break;
						
					case "x":
						//Environment.Exit(0);
						Console.WriteLine("Exitting ...");
						Console.Write("Press any key to continue . . . ");
						Console.ReadKey(true);
						Environment.Exit(0);
						break;
						
					default:
						Console.WriteLine("Please choose the right key.");
						break;
				}
			}
		}
		
		public static void checkAutoUpdate()
		{
			
			Console.WriteLine("checking update ....");
			WebClient client = new WebClient();
			string remoteVersionText = client.DownloadString(remoteVersionURL).Trim();
			string[] remoteVersionParts = (new Regex(@"\s+")).Split(remoteVersionText);
			string remoteUrl = remoteVersionParts[1];
			string remoteHash = remoteVersionParts[2];
			
			if(!File.Exists("version.txt"))
			{
				Console.Write("No version file detected. Calling program to obtain version - ");
				ProcessStartInfo startInfo = new ProcessStartInfo("program.exe");
				startInfo.Arguments = "writeversion";
				Process versionWriter = new Process();
				versionWriter.StartInfo = startInfo;
				versionWriter.Start();
				versionWriter.WaitForExit();
				Console.WriteLine("done.");
			}

			Version localVersion = new Version(File.ReadAllText("version.txt").Trim());
			Version remoteVersion = new Version(remoteVersionParts[0]);

			if(remoteVersion > localVersion)
			{
				// There is a new version on the server!
				Console.WriteLine("There is a new version available on the server.");
				Console.WriteLine("Current Version: {0}, New version: {1}", localVersion, remoteVersion);
				while (true)
				{
					Console.Write("Perform update? ");
					string response = Console.ReadLine().Trim().ToLower();
					if (response.StartsWith("y"))
					{
						PerformUpdate(remoteUrl, remoteHash);
						break;
					}
					else if (response.StartsWith("n"))
					{
						Console.WriteLine("Abort.");
						break;
					}
				}
			}
		}//end checkAutoUpdate;
		
		public static void checkAppInstance()
		{
			if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
			{
			  //System.Diagnostics.EventLog.WriteEntry("Application XXXX already running. Only one instance of this application is allowed", AppLog.LogMessageType.Warn);
			  System.Windows.Forms.MessageBox.Show("Already running");
			  Environment.Exit(0);
			}
		}//end checkAppInstance;
		
		static bool PerformUpdate(string remoteUrl, string expectedHash)
		{
			Console.WriteLine("Beginning update.");
			string downloadDestination = Path.GetTempFileName();
	
			Console.Write("Downloading {0} to {1} - ", remoteUrl, downloadDestination);
			WebClient downloadifier = new WebClient();
			downloadifier.DownloadFile(remoteUrl, downloadDestination);
			Console.WriteLine("done.");
			
			Console.Write("Validating download - ");
			string downloadHash = GetSHA1HashFromFile(downloadDestination);
			if (downloadHash.Trim().ToLower() != expectedHash.Trim().ToLower()) {
				// The downloaded file looks bad!
				// Destroy it quick before it can do any more damage!
				File.Delete(downloadDestination);
				// Tell the user about what has happened
				Console.WriteLine("Fail!");
				Console.WriteLine("Expected {0}, but actually got {1}).", expectedHash, downloadHash);
				Console.WriteLine("The downloaded update may have been modified by an attacker in transit!");
				Console.WriteLine("Nothing has been changed, and the downloaded file deleted.");
				return false;
			}
			else
				Console.WriteLine("ok.");
			
			// Since the download doesn't appear to be bad at first sight, let's extract it
			Console.Write("Extracting archive - ");
			string extractTarget = @"./downloadedFiles";
			ZipFile.ExtractToDirectory(downloadDestination, extractTarget);
			// Copy the extracted files and replace everything in the current directory to finish the update
			// C# doesn't easily let us extract & replace at the same time
			// From http://stackoverflow.com/a/3822913/1460422
			foreach (string newPath in Directory.GetFiles(extractTarget, "*.*", SearchOption.AllDirectories))
				File.Copy(newPath, newPath.Replace(extractTarget, "."), true);
			Console.WriteLine("done.");
	
			// Clean up the temporary files
			Console.Write("Cleaning up - ");
			Directory.Delete(extractTarget, true);
			Console.WriteLine("done.");
	
			return true;
		}//end Update;
		
		
		/// <summary>
		/// Gets the SHA1 hash from file.
		/// Adapted from https://stackoverflow.com/a/16318156/1460422
		/// </summary>
		/// <param name="fileName">The filename to hash.</param>
		/// <returns>The SHA1 hash from file.</returns>
		static string GetSHA1HashFromFile(string fileName)
		{
			FileStream file = new FileStream(fileName, FileMode.Open);
			SHA1 sha1 = new SHA1CryptoServiceProvider();
			byte[] byteHash = sha1.ComputeHash(file);
			file.Close();
	
			StringBuilder hashString = new StringBuilder();
			for (int i = 0; i < byteHash.Length; i++)
				hashString.Append(byteHash[i].ToString("x2"));
			return hashString.ToString();
		}
		
	}//END Class
}//END NAMESPACE