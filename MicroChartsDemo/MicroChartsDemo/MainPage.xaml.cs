using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Entry = Microcharts.ChartEntry;
using Microcharts;
namespace MicroChartsDemo
{

    public partial class MainPage : ContentPage
    {

        private static readonly SkiaSharp.SKColor GraphColor = SkiaSharp.SKColor.Parse("#16b302");
        private ChartEntries chartEntries1;
        private ChartEntries chartEntries2;
        public MainPage()
        {
            InitializeComponent();
            chartEntries1 = new ChartEntries(50, "#06c406");
            chartEntries2 = new ChartEntries(50, "#fcfc30");
            Chart1.Chart = new LineChart
            {
                Entries = chartEntries1.GetEntries(),
                LineMode = LineMode.Straight,
                PointMode = PointMode.None,
                LineSize = 8,
                BackgroundColor = SkiaSharp.SKColors.Transparent
            };

            Chart2.Chart = new LineChart
            {
                Entries = chartEntries2.GetEntries(),
                LineMode = LineMode.Straight,
                PointMode = PointMode.None,
                LineSize = 8,
                BackgroundColor = SkiaSharp.SKColors.Transparent
            };

        }
        void OnButtonClicked(object sender, EventArgs e)
        {
            Random random = new Random();

            Chart1.Chart.Entries = chartEntries1.AddPoint(random.Next(-100, 100));
            Chart2.Chart.Entries = chartEntries2.AddPoint(random.Next(-100, 100));


        }

    }
}
