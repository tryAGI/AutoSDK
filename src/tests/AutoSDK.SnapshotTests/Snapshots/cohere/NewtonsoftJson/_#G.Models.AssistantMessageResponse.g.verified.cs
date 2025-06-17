//HintName: G.Models.AssistantMessageResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A message from the assistant role can contain text and tool call information.
    /// </summary>
    public sealed partial class AssistantMessageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("citations")]
        public global::System.Collections.Generic.IList<global::G.Citation>? Citations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::System.Collections.Generic.IList<global::G.ContentItem>? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.AssistantMessageResponseRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ToolCallV2>? ToolCalls { get; set; }

        /// <summary>
        /// A chain-of-thought style reflection and plan that the model generates when working with Tools.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_plan")]
        public string? ToolPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageResponse" /> class.
        /// </summary>
        /// <param name="citations"></param>
        /// <param name="content"></param>
        /// <param name="role"></param>
        /// <param name="toolCalls"></param>
        /// <param name="toolPlan">
        /// A chain-of-thought style reflection and plan that the model generates when working with Tools.
        /// </param>
        public AssistantMessageResponse(
            global::System.Collections.Generic.IList<global::G.Citation>? citations,
            global::System.Collections.Generic.IList<global::G.ContentItem>? content,
            global::G.AssistantMessageResponseRole role,
            global::System.Collections.Generic.IList<global::G.ToolCallV2>? toolCalls,
            string? toolPlan)
        {
            this.Citations = citations;
            this.Content = content;
            this.Role = role;
            this.ToolCalls = toolCalls;
            this.ToolPlan = toolPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageResponse" /> class.
        /// </summary>
        public AssistantMessageResponse()
        {
        }
    }
}