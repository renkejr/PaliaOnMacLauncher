// See https://aka.ms/new-console-template for more information

using PaliaOnMacLauncher;
using System.Runtime.InteropServices;

var commandArgs = Environment.GetCommandLineArgs().ToList();
var defaultDrive = RuntimeInformation.IsOSPlatform(OSPlatform.OSX) ? "drive_c" : "C";
var installationPath = commandArgs.ElementAtOrDefault(1) ?? Path.Combine(defaultDrive, "Program Files", "Palia");
var patchManifestUrl = commandArgs.ElementAtOrDefault(2) ?? "https://update.palia.com/manifest/PatchManifest.json";

Console.WriteLine("Installation Path: {0}", installationPath);
Console.WriteLine("Patch Manifest Url: {0}", patchManifestUrl);

var launcher = new Launcher(installationPath, patchManifestUrl);
launcher.Start();
