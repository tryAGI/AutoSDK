//HintName: G.Models.InsightRunFormatPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InsightRunFormatPlan
    {
        /// <summary>
        /// This is the format of the data to return.<br/>
        /// If not provided, defaults to "raw".<br/>
        /// Raw provides the data as fetched from the database, with formulas evaluated.<br/>
        /// Recharts provides the data in a format that can is ready to be used by recharts.js to render charts.<br/>
        /// Example: raw
        /// </summary>
        /// <example>raw</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InsightRunFormatPlanFormatJsonConverter))]
        public global::G.InsightRunFormatPlanFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InsightRunFormatPlan" /> class.
        /// </summary>
        /// <param name="format">
        /// This is the format of the data to return.<br/>
        /// If not provided, defaults to "raw".<br/>
        /// Raw provides the data as fetched from the database, with formulas evaluated.<br/>
        /// Recharts provides the data in a format that can is ready to be used by recharts.js to render charts.<br/>
        /// Example: raw
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InsightRunFormatPlan(
            global::G.InsightRunFormatPlanFormat? format)
        {
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsightRunFormatPlan" /> class.
        /// </summary>
        public InsightRunFormatPlan()
        {
        }
    }
}