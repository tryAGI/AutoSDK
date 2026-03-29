//HintName: G.Models.MessagesResultUsageCacheCreation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesResultUsageCacheCreation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ephemeral_5m_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Ephemeral5mInputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ephemeral_1h_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Ephemeral1hInputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResultUsageCacheCreation" /> class.
        /// </summary>
        /// <param name="ephemeral5mInputTokens"></param>
        /// <param name="ephemeral1hInputTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesResultUsageCacheCreation(
            double ephemeral5mInputTokens,
            double ephemeral1hInputTokens)
        {
            this.Ephemeral5mInputTokens = ephemeral5mInputTokens;
            this.Ephemeral1hInputTokens = ephemeral1hInputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResultUsageCacheCreation" /> class.
        /// </summary>
        public MessagesResultUsageCacheCreation()
        {
        }
    }
}