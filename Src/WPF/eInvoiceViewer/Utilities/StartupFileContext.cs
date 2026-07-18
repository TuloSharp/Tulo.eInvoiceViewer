namespace Tulo.eInvoiceViewer.Utilities;
public sealed class StartupFileContext : IStartupFileContext
{
    public string? FilePath { get; }

    public event Action<string>? NewFileRequested;

    public StartupFileContext(string? filePath)
    {
        FilePath = filePath;
    }

    public void RequestFile(string filePath)
    {
        NewFileRequested?.Invoke(filePath);
    }
}
