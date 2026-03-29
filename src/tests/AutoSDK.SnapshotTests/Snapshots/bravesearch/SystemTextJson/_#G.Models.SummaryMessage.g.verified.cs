//HintName: G.Models.SummaryMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single paragraph or section in the summary.
    /// </summary>
    public sealed partial class SummaryMessage
    {
        /// <summary>
        /// Type of the summary section (e.g., paragraph, token).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The text content of the summary section.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryMessage" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of the summary section (e.g., paragraph, token).
        /// </param>
        /// <param name="data">
        /// The text content of the summary section.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SummaryMessage(
            string? type,
            string? data)
        {
            this.Type = type;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryMessage" /> class.
        /// </summary>
        public SummaryMessage()
        {
        }
    }
}