﻿//HintName: G.Models.CustomChartUpdate.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public global::G.AnyOf<string, global::G.Missing>? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public global::G.AnyOf<string, global::G.Missing>? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public global::G.AnyOf<int?, global::G.Missing>? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chart_type")]
        public global::G.AnyOf<global::G.CustomChartType?, global::G.Missing>? ChartType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("series")]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::G.CustomChartSeriesUpdate>, global::G.Missing>? Series { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("section_id")]
        public global::G.AnyOf<global::System.Guid?, global::G.Missing>? SectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.AnyOf<object, global::G.Missing>? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("common_filters")]
        public global::G.AnyOf<global::G.CustomChartSeriesFilters, global::G.Missing>? CommonFilters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartUpdate" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="index"></param>
        /// <param name="chartType"></param>
        /// <param name="series"></param>
        /// <param name="sectionId"></param>
        /// <param name="metadata"></param>
        /// <param name="commonFilters"></param>
        public CustomChartUpdate(
            global::G.AnyOf<string, global::G.Missing>? title,
            global::G.AnyOf<string, global::G.Missing>? description,
            global::G.AnyOf<int?, global::G.Missing>? index,
            global::G.AnyOf<global::G.CustomChartType?, global::G.Missing>? chartType,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.CustomChartSeriesUpdate>, global::G.Missing>? series,
            global::G.AnyOf<global::System.Guid?, global::G.Missing>? sectionId,
            global::G.AnyOf<object, global::G.Missing>? metadata,
            global::G.AnyOf<global::G.CustomChartSeriesFilters, global::G.Missing>? commonFilters)
        {
            this.Title = title;
            this.Description = description;
            this.Index = index;
            this.ChartType = chartType;
            this.Series = series;
            this.SectionId = sectionId;
            this.Metadata = metadata;
            this.CommonFilters = commonFilters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartUpdate" /> class.
        /// </summary>
        public CustomChartUpdate()
        {
        }
    }
}