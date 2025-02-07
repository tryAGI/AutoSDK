//HintName: G.Models.MonitorBlock.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MonitorBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("section")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Section { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Columns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtitle")]
        public string? Subtitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>> Rows { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chart_spec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ChartSpec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("click_target")]
        public string? ClickTarget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toggleable_marks")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<int>>? ToggleableMarks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorBlock" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="section"></param>
        /// <param name="columns"></param>
        /// <param name="subtitle"></param>
        /// <param name="rows"></param>
        /// <param name="chartSpec"></param>
        /// <param name="clickTarget"></param>
        /// <param name="toggleableMarks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MonitorBlock(
            string title,
            string section,
            global::System.Collections.Generic.IList<string> columns,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>> rows,
            object chartSpec,
            string? subtitle,
            string? clickTarget,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<int>>? toggleableMarks)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Section = section ?? throw new global::System.ArgumentNullException(nameof(section));
            this.Columns = columns ?? throw new global::System.ArgumentNullException(nameof(columns));
            this.Rows = rows ?? throw new global::System.ArgumentNullException(nameof(rows));
            this.ChartSpec = chartSpec ?? throw new global::System.ArgumentNullException(nameof(chartSpec));
            this.Subtitle = subtitle;
            this.ClickTarget = clickTarget;
            this.ToggleableMarks = toggleableMarks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorBlock" /> class.
        /// </summary>
        public MonitorBlock()
        {
        }
    }
}