using System.Diagnostics;

DirectoryInfo dir = new (Environment.CurrentDirectory + "/../../../..");

Console.WriteLine("Generating docs...");
Console.WriteLine($"{dir.FullName}/docfx ./docfx.json");

Process p = new ()
{
    StartInfo =
    {
        WorkingDirectory = dir.FullName,
        FileName = "docfx",
        Arguments = "./docfx.json",
        RedirectStandardOutput = true,
        RedirectStandardError = true,
    }
};

p.Start();
p.WaitForExit();
