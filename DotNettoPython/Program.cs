// Program.cs
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // The path to the Python interpreter (you can specify the absolute path if needed)
        string python = "python3";

        // The path to the Python script (make sure it's correctly set)
        string script = "/home/chaithanya/Documents/Dotnet_to_Python/linux-x64/script.py";  // Update the path accordingly

        // Arguments to pass to the Python script
        string pythonArgs = "Hello From DotNet!";

        // Create a new process to call Python
        var process = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = python,
                Arguments = $"{script} {pythonArgs}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            }
        };

        // Start the process
        process.Start();

        // Capture and print the output of the Python script
        string output = process.StandardOutput.ReadToEnd();
        string errors = process.StandardError.ReadToEnd();
        process.WaitForExit();

        // Output the result from the Python script
        Console.WriteLine("Output from Python script:");
        Console.WriteLine(output);

        // Output errors (if any)
        if (!string.IsNullOrEmpty(errors))
        {
            Console.WriteLine("Errors from Python script:");
            Console.WriteLine(errors);
        }
    }
}
