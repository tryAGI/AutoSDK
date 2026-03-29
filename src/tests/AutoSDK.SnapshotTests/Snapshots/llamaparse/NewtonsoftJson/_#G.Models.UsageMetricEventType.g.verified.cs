//HintName: G.Models.UsageMetricEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type that is emitted
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UsageMetricEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio_seconds_parsed")]
        AudioSecondsParsed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chart_parsing_agentic")]
        ChartParsingAgentic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chart_parsing_efficient")]
        ChartParsingEfficient,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chart_parsing_plus")]
        ChartParsingPlus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="extraction_num_pages")]
        ExtractionNumPages,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="extraction_num_pages_parsed")]
        ExtractionNumPagesParsed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_classified")]
        ImageClassified,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="layout_aware_chart_extraction")]
        LayoutAwareChartExtraction,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="layout_aware_parsing")]
        LayoutAwareParsing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="layout_extracted")]
        LayoutExtracted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pages_classified")]
        PagesClassified,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pages_embedded")]
        PagesEmbedded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pages_indexed")]
        PagesIndexed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pages_parsed")]
        PagesParsed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pages_split")]
        PagesSplit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="precise_bbox_extraction")]
        PreciseBboxExtraction,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="set_total_indexes")]
        SetTotalIndexes,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="set_total_pages_indexed")]
        SetTotalPagesIndexed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageMetricEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageMetricEventType value)
        {
            return value switch
            {
                UsageMetricEventType.AudioSecondsParsed => "audio_seconds_parsed",
                UsageMetricEventType.ChartParsingAgentic => "chart_parsing_agentic",
                UsageMetricEventType.ChartParsingEfficient => "chart_parsing_efficient",
                UsageMetricEventType.ChartParsingPlus => "chart_parsing_plus",
                UsageMetricEventType.ExtractionNumPages => "extraction_num_pages",
                UsageMetricEventType.ExtractionNumPagesParsed => "extraction_num_pages_parsed",
                UsageMetricEventType.ImageClassified => "image_classified",
                UsageMetricEventType.LayoutAwareChartExtraction => "layout_aware_chart_extraction",
                UsageMetricEventType.LayoutAwareParsing => "layout_aware_parsing",
                UsageMetricEventType.LayoutExtracted => "layout_extracted",
                UsageMetricEventType.PagesClassified => "pages_classified",
                UsageMetricEventType.PagesEmbedded => "pages_embedded",
                UsageMetricEventType.PagesIndexed => "pages_indexed",
                UsageMetricEventType.PagesParsed => "pages_parsed",
                UsageMetricEventType.PagesSplit => "pages_split",
                UsageMetricEventType.PreciseBboxExtraction => "precise_bbox_extraction",
                UsageMetricEventType.SetTotalIndexes => "set_total_indexes",
                UsageMetricEventType.SetTotalPagesIndexed => "set_total_pages_indexed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageMetricEventType? ToEnum(string value)
        {
            return value switch
            {
                "audio_seconds_parsed" => UsageMetricEventType.AudioSecondsParsed,
                "chart_parsing_agentic" => UsageMetricEventType.ChartParsingAgentic,
                "chart_parsing_efficient" => UsageMetricEventType.ChartParsingEfficient,
                "chart_parsing_plus" => UsageMetricEventType.ChartParsingPlus,
                "extraction_num_pages" => UsageMetricEventType.ExtractionNumPages,
                "extraction_num_pages_parsed" => UsageMetricEventType.ExtractionNumPagesParsed,
                "image_classified" => UsageMetricEventType.ImageClassified,
                "layout_aware_chart_extraction" => UsageMetricEventType.LayoutAwareChartExtraction,
                "layout_aware_parsing" => UsageMetricEventType.LayoutAwareParsing,
                "layout_extracted" => UsageMetricEventType.LayoutExtracted,
                "pages_classified" => UsageMetricEventType.PagesClassified,
                "pages_embedded" => UsageMetricEventType.PagesEmbedded,
                "pages_indexed" => UsageMetricEventType.PagesIndexed,
                "pages_parsed" => UsageMetricEventType.PagesParsed,
                "pages_split" => UsageMetricEventType.PagesSplit,
                "precise_bbox_extraction" => UsageMetricEventType.PreciseBboxExtraction,
                "set_total_indexes" => UsageMetricEventType.SetTotalIndexes,
                "set_total_pages_indexed" => UsageMetricEventType.SetTotalPagesIndexed,
                _ => null,
            };
        }
    }
}