//HintName: G.Models.SummarizeBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This class is to be used as a common class to all Studio API requests payloads
    /// </summary>
    public sealed partial class SummarizeBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DocumentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DocumentType SourceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("focus")]
        public string? Focus { get; set; }

        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summaryMethod")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SummaryMethodJsonConverter))]
        public global::G.SummaryMethod? SummaryMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizeBody" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="sourceType">
        /// An enumeration.
        /// </param>
        /// <param name="focus"></param>
        /// <param name="summaryMethod">
        /// An enumeration.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SummarizeBody(
            string source,
            global::G.DocumentType sourceType,
            string? focus,
            global::G.SummaryMethod? summaryMethod)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.SourceType = sourceType;
            this.Focus = focus;
            this.SummaryMethod = summaryMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizeBody" /> class.
        /// </summary>
        public SummarizeBody()
        {
        }
    }
}