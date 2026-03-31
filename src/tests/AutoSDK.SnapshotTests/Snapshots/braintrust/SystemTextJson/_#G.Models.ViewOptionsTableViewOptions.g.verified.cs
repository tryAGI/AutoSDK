//HintName: G.Models.ViewOptionsTableViewOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ViewOptionsTableViewOptions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columnVisibility")]
        public global::System.Collections.Generic.Dictionary<string, bool>? ColumnVisibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columnOrder")]
        public global::System.Collections.Generic.IList<string>? ColumnOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columnSizing")]
        public global::System.Collections.Generic.Dictionary<string, double>? ColumnSizing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grouping")]
        public string? Grouping { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rowHeight")]
        public string? RowHeight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tallGroupRows")]
        public bool? TallGroupRows { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout")]
        public string? Layout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chartHeight")]
        public double? ChartHeight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludedMeasures")]
        public global::System.Collections.Generic.IList<global::G.ViewOptionsTableViewOptionsExcludedMeasure>? ExcludedMeasures { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("yMetric")]
        public global::G.ViewOptionsTableViewOptionsYMetric? YMetric { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xAxis")]
        public global::G.ViewOptionsTableViewOptionsXAxis? XAxis { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("symbolGrouping")]
        public global::G.ViewOptionsTableViewOptionsSymbolGrouping? SymbolGrouping { get; set; }

        /// <summary>
        /// One of 'avg', 'sum', 'min', 'max', 'median', 'all'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xAxisAggregation")]
        public string? XAxisAggregation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chartAnnotations")]
        public global::System.Collections.Generic.IList<global::G.ViewOptionsTableViewOptionsChartAnnotation>? ChartAnnotations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeRangeFilter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::G.ViewOptionsTableViewOptionsTimeRangeFilter, object>))]
        public global::G.AnyOf<string, global::G.ViewOptionsTableViewOptionsTimeRangeFilter, object>? TimeRangeFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queryShape")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ViewOptionsTableViewOptionsQueryShapeJsonConverter))]
        public global::G.ViewOptionsTableViewOptionsQueryShape? QueryShape { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("freezeColumns")]
        public bool? FreezeColumns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewOptionsTableViewOptions" /> class.
        /// </summary>
        /// <param name="columnVisibility"></param>
        /// <param name="columnOrder"></param>
        /// <param name="columnSizing"></param>
        /// <param name="grouping"></param>
        /// <param name="rowHeight"></param>
        /// <param name="tallGroupRows"></param>
        /// <param name="layout"></param>
        /// <param name="chartHeight"></param>
        /// <param name="excludedMeasures"></param>
        /// <param name="yMetric"></param>
        /// <param name="xAxis"></param>
        /// <param name="symbolGrouping"></param>
        /// <param name="xAxisAggregation">
        /// One of 'avg', 'sum', 'min', 'max', 'median', 'all'
        /// </param>
        /// <param name="chartAnnotations"></param>
        /// <param name="timeRangeFilter"></param>
        /// <param name="queryShape"></param>
        /// <param name="freezeColumns"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ViewOptionsTableViewOptions(
            global::System.Collections.Generic.Dictionary<string, bool>? columnVisibility,
            global::System.Collections.Generic.IList<string>? columnOrder,
            global::System.Collections.Generic.Dictionary<string, double>? columnSizing,
            string? grouping,
            string? rowHeight,
            bool? tallGroupRows,
            string? layout,
            double? chartHeight,
            global::System.Collections.Generic.IList<global::G.ViewOptionsTableViewOptionsExcludedMeasure>? excludedMeasures,
            global::G.ViewOptionsTableViewOptionsYMetric? yMetric,
            global::G.ViewOptionsTableViewOptionsXAxis? xAxis,
            global::G.ViewOptionsTableViewOptionsSymbolGrouping? symbolGrouping,
            string? xAxisAggregation,
            global::System.Collections.Generic.IList<global::G.ViewOptionsTableViewOptionsChartAnnotation>? chartAnnotations,
            global::G.AnyOf<string, global::G.ViewOptionsTableViewOptionsTimeRangeFilter, object>? timeRangeFilter,
            global::G.ViewOptionsTableViewOptionsQueryShape? queryShape,
            bool? freezeColumns)
        {
            this.ColumnVisibility = columnVisibility;
            this.ColumnOrder = columnOrder;
            this.ColumnSizing = columnSizing;
            this.Grouping = grouping;
            this.RowHeight = rowHeight;
            this.TallGroupRows = tallGroupRows;
            this.Layout = layout;
            this.ChartHeight = chartHeight;
            this.ExcludedMeasures = excludedMeasures;
            this.YMetric = yMetric;
            this.XAxis = xAxis;
            this.SymbolGrouping = symbolGrouping;
            this.XAxisAggregation = xAxisAggregation;
            this.ChartAnnotations = chartAnnotations;
            this.TimeRangeFilter = timeRangeFilter;
            this.QueryShape = queryShape;
            this.FreezeColumns = freezeColumns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewOptionsTableViewOptions" /> class.
        /// </summary>
        public ViewOptionsTableViewOptions()
        {
        }
    }
}