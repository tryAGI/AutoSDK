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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "AgentThinking";

        /// <summary>
        /// The thinking content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentThinking" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="content">
        /// The thinking content.
        /// </param>
        public AgentThinking(
            string content,
            string type = "AgentThinking")
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentThinking" /> class.
        /// </summary>
        public AgentThinking()
        {
        }
    }
}