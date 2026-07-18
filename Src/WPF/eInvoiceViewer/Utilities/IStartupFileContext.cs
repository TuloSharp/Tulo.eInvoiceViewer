namespace Tulo.eInvoiceViewer.Utilities;
public interface IStartupFileContext
{
    string? FilePath { get; }

    event Action<string>? NewFileRequested;
    void RequestFile(string filePath);
}

