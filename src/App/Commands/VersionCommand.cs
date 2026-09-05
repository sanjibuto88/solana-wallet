using SolWallet.App.Output;

namespace SolWallet.App.Commands;

public sealed class VersionCommand
{
    public Task<int> ExecuteAsync(string[] args)
    {
        var assembly = typeof(VersionCommand).Assembly;
        var version = assembly.GetName().Version?.ToString() ?? "2.4.1";
        ConsoleOutputFormatter.WriteHeader("solwallet");
        ConsoleOutputFormatter.WriteKeyValue("version", version);
        ConsoleOutputFormatter.WriteKeyValue("runtime", Environment.Version.ToString());
        ConsoleOutputFormatter.WriteKeyValue("platform", Environment.OSVersion.VersionString);
        ConsoleOutputFormatter.WriteKeyValue("arch", Environment.Is64BitProcess ? "x64" : "x86");
        return Task.FromResult(0);
    }
}
