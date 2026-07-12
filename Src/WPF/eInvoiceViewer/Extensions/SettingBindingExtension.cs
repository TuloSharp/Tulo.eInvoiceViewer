using System.Windows.Data;
using Tulo.eInvoiceViewer.Properties;

namespace Tulo.eInvoiceViewer.Extensions;

public class SettingBindingExtension : Binding
{
    public SettingBindingExtension()
    {
        Initialize();
    }

    public SettingBindingExtension(string path) : base(path)
    {
        Initialize();
    }

    private void Initialize()
    {
        Source = Settings.Default;
        Mode = BindingMode.TwoWay;
    }
}
