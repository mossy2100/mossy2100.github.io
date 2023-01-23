using System.Diagnostics;

DirectoryInfo dir = new (Environment.CurrentDirectory + "/../../../../");

CompileScss();
GenerateDocs();

////////////////////////////////////////////////////////////////////////////////////////////////////

// Output the full command to the console.
void PrintCommand(Process p) =>
    Console.WriteLine($"{p.StartInfo.WorkingDirectory}/{p.StartInfo.FileName} {p.StartInfo.Arguments}");

// Compile the SCSS.
void CompileScss()
{
    using Process procCompileScss = new ();
    procCompileScss.StartInfo = new ProcessStartInfo
    {
        WorkingDirectory = dir.FullName,
        FileName = "gulp",
        Arguments = "compile",
    };

    Console.WriteLine("Compiling SCSS...");
    PrintCommand(procCompileScss);

    procCompileScss.Start();
    procCompileScss.WaitForExit();
}

// Build the docs.
void GenerateDocs()
{
    using Process procBuildDocs = new ();
    procBuildDocs.StartInfo = new ProcessStartInfo
    {
        WorkingDirectory = dir.FullName,
        FileName = "docfx",
        Arguments = "./docfx.json",
    };

    Console.WriteLine("Generating documentation...");
    PrintCommand(procBuildDocs);

    procBuildDocs.Start();
    procBuildDocs.WaitForExit();
}
