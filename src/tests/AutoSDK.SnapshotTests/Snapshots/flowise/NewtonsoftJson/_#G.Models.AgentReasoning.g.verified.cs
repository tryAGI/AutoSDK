//HintName: G.Models.AgentReasoning.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentReasoning
    {
        /// <summary>
        /// Example: agent
        /// </summary>
        /// <example>agent</example>
        [global::Newtonsoft.Json.JsonProperty("agentName")]
        public string? AgentName { get; set; }

        /// <summary>
        /// Example: [hello]
        /// </summary>
        /// <example>[hello]</example>
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<string>? Messages { get; set; }

        /// <summary>
        /// Example: seqAgent
        /// </summary>
        /// <example>seqAgent</example>
        [global::Newtonsoft.Json.JsonProperty("nodeName")]
        public string? NodeName { get; set; }

        /// <summary>
        /// Example: seqAgent_0
        /// </summary>
        /// <example>seqAgent_0</example>
        [global::Newtonsoft.Json.JsonProperty("nodeId")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usedTools")]
        public global::System.Collections.Generic.IList<global::G.UsedTool>? UsedTools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sourceDocuments")]
        public global::System.Collections.Generic.IList<global::G.Document>? SourceDocuments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::System.Collections.Generic.Dictionary<string, string>? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentReasoning" /> class.
        /// </summary>
        /// <param name="agentName">
        /// Example: agent
        /// </param>
        /// <param name="messages">
        /// Example: [hello]
        /// </param>
        /// <param name="nodeName">
        /// Example: seqAgent
        /// </param>
        /// <param name="nodeId">
        /// Example: seqAgent_0
        /// </param>
        /// <param name="usedTools"></param>
        /// <param name="sourceDocuments"></param>
        /// <param name="state"></param>
        public AgentReasoning(
            string? agentName,
            global::System.Collections.Generic.IList<string>? messages,
            string? nodeName,
            string? nodeId,
            global::System.Collections.Generic.IList<global::G.UsedTool>? usedTools,
            global::System.Collections.Generic.IList<global::G.Document>? sourceDocuments,
            global::System.Collections.Generic.Dictionary<string, string>? state)
        {
            this.AgentName = agentName;
            this.Messages = messages;
            this.NodeName = nodeName;
            this.NodeId = nodeId;
            this.UsedTools = usedTools;
            this.SourceDocuments = sourceDocuments;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentReasoning" /> class.
        /// </summary>
        public AgentReasoning()
        {
        }
    }
}