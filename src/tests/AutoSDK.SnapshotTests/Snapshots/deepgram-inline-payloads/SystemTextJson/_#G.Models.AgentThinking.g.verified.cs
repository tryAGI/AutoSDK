//HintName: G.Models.AgentThinking.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Indicates the agent is processing.
    /// </summary>
    public sealed partial class AgentThinking
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"AgentThinking"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "AgentThinking";

        /// <summary>
        /// The thinking content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentThinking" /> class.
        /// </summary>
        /// <param name="content">
        /// The thinking content.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentThinking(
            string content,
            string type = "AgentThinking")
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentThinking" /> class.
        /// </summary>
        public AgentThinking()
        {
        }
    }
}