//HintName: G.Models.LLMResponseBodyToolDetailsResponseMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMResponseBodyToolDetailsResponseMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMResponseBodyToolDetailsResponseMetadata" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMResponseBodyToolDetailsResponseMetadata(
            string timestamp)
        {
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMResponseBodyToolDetailsResponseMetadata" /> class.
        /// </summary>
        public LLMResponseBodyToolDetailsResponseMetadata()
        {
        }
    }
}