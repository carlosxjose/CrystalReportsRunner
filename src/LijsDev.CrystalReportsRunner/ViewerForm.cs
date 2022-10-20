namespace LijsDev.CrystalReportsRunner;

using System.Windows.Forms;

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

using LijsDev.CrystalReportsRunner.Abstractions;

internal partial class ViewerForm : Form
{
    public ViewerForm(ReportDocument document, ReportViewerSettings viewerSettings)
    {
        InitializeComponent();

        crystalReportViewer1.ReportSource = document;
        Text = document.SummaryInfo.ReportTitle;

        if (viewerSettings.ProductLocaleLCID != null)
        {
            crystalReportViewer1.SetProductLocale(viewerSettings.ProductLocaleLCID.Value);
        }

        crystalReportViewer1.AllowedExportFormats = (int)viewerSettings.AllowedExportFormats;

        crystalReportViewer1.ShowRefreshButton = viewerSettings.ShowRefreshButton;
        crystalReportViewer1.ShowCopyButton = viewerSettings.ShowCopyButton;
        crystalReportViewer1.ShowGroupTreeButton = viewerSettings.ShowGroupTreeButton;
        crystalReportViewer1.ShowParameterPanelButton = viewerSettings.ShowParameterPanelButton;
        crystalReportViewer1.ToolPanelView = (ToolPanelViewType)(int)viewerSettings.ToolPanelView;

        crystalReportViewer1.EnableDrillDown = viewerSettings.EnableDrillDown;
        crystalReportViewer1.EnableRefresh = viewerSettings.EnableRefresh;

        crystalReportViewer1.ShowCloseButton = viewerSettings.ShowCloseButton;
    }

}
