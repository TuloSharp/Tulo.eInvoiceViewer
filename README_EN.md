# eInvoice PDF Viewer

A simple open-source tool for viewing supported eInvoice XML files as PDF.

This project is designed to make it easy to open a supported invoice XML file and display it in a PDF-like visual form.

It is especially useful for users who work with structured electronic invoice files and want to quickly preview them in a readable document layout.

![Image 1](./ReadMeImages/Animation_01.gif)

![Image 2](./ReadMeImages/UiImage01.png)

![Image 3](./ReadMeImages/UiImage02.png)

---

## What this program does

This application allows a user to open a supported eInvoice XML file and display it as a PDF view.

The main purpose is to make XML-based invoice data easier to read for humans.

The program adds a context menu action, so a user can right-click a supported XML invoice file and open it directly as a PDF preview.

This feature is intended for supported **eInvoices** only.  
It does **not** convert every arbitrary XML file.  
Only XML files that match the supported invoice standards and structures can be displayed correctly.

---

## Supported invoice formats

This library generates PDF renderings from XML e‑invoices in the following syntaxes:

   - UN/CEFACT Cross Industry Invoice (CII) – e.g. as used by XRechnung or ZUGFeRD/Factur‑X (CII profile)
   - OASIS UBL (Invoice / CreditNote) – via the UBL namespaces cbc and cac

The code automatically detects whether the input XML is UBL or CII by trying multiple XPath variants for key fields (e.g. invoice number, date, seller, buyer) and using the first one that matches.
EN 16931 context

EN 16931 defines the semantic data model for European electronic invoices and provides bindings for UBL and CII.
This library does not perform EN‑16931 validation itself (no schema/schematron/business‑rule checks), but it can visually render XML invoices that are already EN‑16931‑compliant into a readable PDF.

---

## Important disclaimer

Please read the disclaimer information available inside the application.

You can find it in:

**View -> About**

This information is important and should be read before using the application in productive, legal, business, or compliance-related scenarios.

The disclaimer shown in the application is the relevant notice for usage, limitations, and responsibility.

---

## Open Source

This project is open source and can be used, modified, and improved by the community.

---

## Requirements

| Requirement | Detail |
|---|---|
| OS | Windows x64 |
| Runtime | .NET 8 (must be installed separately) |
| .NET Download | https://dotnet.microsoft.com/en-us/download/dotnet/8.0 |

---

## Getting started

1. Go to the [Releases](../../releases) page
2. Download the latest `.zip` file
3. Create a folder structure as described in the [Configuration — end users](#configuration--end-users) section
4. Extract the ZIP into the `Tulo.eInvoiceViewer/` folder
5. Edit your `appsettings.json` in the `Tulo.eInvoiceViewer-appsettings/` folder with your seller data and preferences
6. Run `Tulo.eInvoiceViewer.exe`

No installer required.

---

## Third-Party Libraries

This project uses the following third-party NuGet packages:

- PDFsharp-extended (v1.3.0)
- Markdig.Wpf (v0.5.0.1)
- Serilog (v4.2.0)
- tulo.CommonMVVM.WPF (v1.0.0)
- tulo.CoreLib (v1.0.0)
- tulo.LoadingSpinnerControl (v1.0.0)
- tulo.ResourcesWpfLib (v1.0.0)
- tulo.SerilogLib (v1.0.0)
- tulo.XMLeInvoiceToPdf (v1.0.0)

All credits for these libraries go to their respective authors and maintainers.

Note: The source code for tulo.XMLeInvoiceToPdf is available in the GitHub repository: https://github.com/TuloSharp/tulo.eInvoiceApp.git

---

## Supported invoice types

This project is intended for XML invoice files based on structured eInvoicing standards.

For example, it is focused on invoice formats in the area of:

- CII invoices
- EN16931 invoice structures
- related supported eInvoice XML formats

Only supported invoice XML structures can be rendered correctly.  
Other XML files are ignored or cannot be displayed as PDF.

---

## Features

- Open supported eInvoice XML files as PDF view
- Human-readable display of structured invoice content
- Right-click context menu integration in Windows Explorer
- Fast preview of invoice XML documents
- Works with supported invoice examples from the project
- Designed for practical usage and easy understanding
- Open-source and extendable for further invoice formats

---

## How it works

The application reads a supported XML invoice file, interprets the invoice structure, and creates or displays a PDF-style visual representation of the invoice.

This means the XML stays the source input, but the user sees the invoice in a readable document form instead of raw XML text.

---

## Important limitation

This tool is **not a general XML-to-PDF converter**.

That means:

- not every XML file can be opened
- not every business XML format is supported
- only supported eInvoice invoice structures are expected to work

If a file is not a valid supported invoice XML file, the PDF preview may fail or may not be available.

---

## Example use case

A user receives or creates an electronic invoice in XML format.

Instead of opening the raw XML in a text editor, the user can right-click the invoice file and choose the PDF display action.

The application then opens the invoice in a readable PDF-style representation.

This is useful for:

- checking invoice content visually
- reviewing invoice data without reading XML
- testing invoice examples in development
- validating the practical readability of generated invoice files

---

## Context menu integration

One of the main features of this project is the Windows Explorer integration.

A supported XML invoice file can be opened by using the right mouse button and selecting the corresponding action for PDF display.

This makes the tool convenient for daily work because the user does not need to manually start the program first.

---

## Example invoice files

The project can include example invoice XML files for testing and demonstration purposes.

Example files may be located in folders such as:

- `Examples\`

These files can be copied to the output directory during build so they are available for testing and preview.

---

## Build and development notes

When example XML files are included in the project, it is useful to copy them automatically to the output folder.

Example:

```xml
<ItemGroup>
  <None Update="Examples\**\*.xml">
    <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
  </None>
</ItemGroup>
```

---

## Notes

- Logging helps identify missing arguments and file path problems.
- This tool is intended for simple and practical to show an eInvocie XML Cii format.

---

## UI Icons

This project uses **Google Material Icons** in the user interface.

All credits go to their respective authors and maintainers.

---

## Support

This tool is a private project. If it helps you, support is appreciated.

- ☕ [PayPal](https://paypal.me/MarceloGuartanAndrad)
- ⭐ [GitHub](https://github.com/TuloSharp/Tulo.eInvoiceCreatorZUGFeRD.git)

---

## License

- **Apache License, Version 2.0**
- https://www.apache.org/licenses/LICENSE-2.0