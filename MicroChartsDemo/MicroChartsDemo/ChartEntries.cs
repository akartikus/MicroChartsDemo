using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entry = Microcharts.ChartEntry;

namespace MicroChartsDemo
{
    public class ChartEntries
    {
        private List<Entry> entries { get; set; }
        private int pointLimit;
        private SkiaSharp.SKColor graphColor;

        public ChartEntries(int pointLimit, string color)
        {
            graphColor = SkiaSharp.SKColor.Parse(color);
            entries = new List<Entry>();
            for(int i = 0; i< pointLimit; i++)
            {
                entries.Add(GenerateChartEntry(0));
            }
            // FIXME : Unused?
            this.pointLimit = pointLimit;
        }

        public List<Entry> AddPoint(int value)
        {
            entries.RemoveAt(0);
            entries.Add(GenerateChartEntry(value));
            return entries;
        }


        public List<Entry> GetEntries()
        {
            return entries;
        }

        private Entry GenerateChartEntry(int value)
        {
            return new Entry(value)
            {
                Color = graphColor,
                TextColor = graphColor,
                Label = "",
                ValueLabel = value + ""
            };
        }
    }
    
}
