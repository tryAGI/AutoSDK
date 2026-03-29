//HintName: G.Models.CompactionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompactionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_messages_before")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumMessagesBefore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_messages_after")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumMessagesAfter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionResponse" /> class.
        /// </summary>
        /// <param name="summary"></param>
        /// <param name="numMessagesBefore"></param>
        /// <param name="numMessagesAfter"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompactionResponse(
            string summary,
            int numMessagesBefore,
            int numMessagesAfter)
        {
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.NumMessagesBefore = numMessagesBefore;
            this.NumMessagesAfter = numMessagesAfter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionResponse" /> class.
        /// </summary>
        public CompactionResponse()
        {
        }
    }
}