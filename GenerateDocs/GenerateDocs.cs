using System.Diagnostics;

DirectoryInfo dir = new (Environment.CurrentDirectory + "/../../../..");

Console.WriteLine("Generating docs...");
Console.WriteLine($"{dir.FullName}/docfx ./docfx.json");

using Process p = new ();
p.StartInfo = new ProcessStartInfo
{
    WorkingDirectory = dir.FullName,
    FileName = "docfx",
    Arguments = "./docfx.json",
};
p.Start();
p.WaitForExit();
