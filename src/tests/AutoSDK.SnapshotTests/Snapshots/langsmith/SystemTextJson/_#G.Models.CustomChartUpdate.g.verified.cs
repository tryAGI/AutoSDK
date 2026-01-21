//HintName: G.Models.CustomChartUpdate.g.cs

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
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::G.Missing>))]
        public global::G.AnyOf<string, global::G.Missing>? Title { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::G.Missing, object>))]
        public global::G.AnyOf<string, global::G.Missing, object>? Description { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<int?, global::G.Missing>))]
        public global::G.AnyOf<int?, global::G.Missing>? Index { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chart_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.CustomChartType?, global::G.Missing>))]
        public global::G.AnyOf<global::G.CustomChartType?, global::G.Missing>? ChartType { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("series")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.CustomChartSeriesUpdate>, global::G.Missing>))]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::G.CustomChartSeriesUpdate>, global::G.Missing>? Series { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("section_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::G.Missing>))]
        public global::G.AnyOf<global::System.Guid?, global::G.Missing>? SectionId { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<object, global::G.Missing, object>))]
        public global::G.AnyOf<object, global::G.Missing, object>? Metadata { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("common_filters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.CustomChartSeriesFilters2, global::G.Missing, object>))]
        public global::G.AnyOf<global::G.CustomChartSeriesFilters2, global::G.Missing, object>? CommonFilters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartUpdate" /> class.
        /// </summary>
        /// <param name="title">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="description">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="index">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="chartType">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="series">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="sectionId">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="metadata">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="commonFilters">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomChartUpdate(
            global::G.AnyOf<string, global::G.Missing>? title,
            global::G.AnyOf<string, global::G.Missing, object>? description,
            global::G.AnyOf<int?, global::G.Missing>? index,
            global::G.AnyOf<global::G.CustomChartType?, global::G.Missing>? chartType,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.CustomChartSeriesUpdate>, global::G.Missing>? series,
            global::G.AnyOf<global::System.Guid?, global::G.Missing>? sectionId,
            global::G.AnyOf<object, global::G.Missing, object>? metadata,
            global::G.AnyOf<global::G.CustomChartSeriesFilters2, global::G.Missing, object>? commonFilters)
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