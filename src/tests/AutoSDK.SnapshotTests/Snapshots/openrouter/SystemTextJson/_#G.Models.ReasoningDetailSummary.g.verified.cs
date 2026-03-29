//HintName: G.Models.ReasoningDetailSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Reasoning detail summary schema
    /// </summary>
    public sealed partial class ReasoningDetailSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReasoningDetailSummaryTypeJsonConverter))]
        public global::G.ReasoningDetailSummaryType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.ReasoningDetailSummaryFormat?, object>))]
        public global::G.OneOf<global::G.ReasoningDetailSummaryFormat?, object>? Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public double? Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningDetailSummary" /> class.
        /// </summary>
        /// <param name="summary"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="format"></param>
        /// <param name="index"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningDetailSummary(
            string summary,
            global::G.ReasoningDetailSummaryType type,
            string? id,
            global::G.OneOf<global::G.ReasoningDetailSummaryFormat?, object>? format,
            double? index)
        {
            this.Type = type;
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Id = id;
            this.Format = format;
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningDetailSummary" /> class.
        /// </summary>
        public ReasoningDetailSummary()
        {
        }
    }
}