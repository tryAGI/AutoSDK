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
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AssistantMessageResponseRoleJsonConverter))]
        public global::G.AssistantMessageResponseRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ToolCallV2>? ToolCalls { get; set; }

        /// <summary>
        /// A chain-of-thought style reflection and plan that the model generates when working with Tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_plan")]
        public string? ToolPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::G.ContentItem>? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        public global::System.Collections.Generic.IList<global::G.Citation>? Citations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageResponse" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="toolCalls"></param>
        /// <param name="toolPlan">
        /// A chain-of-thought style reflection and plan that the model generates when working with Tools.
        /// </param>
        /// <param name="content"></param>
        /// <param name="citations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantMessageResponse(
            global::G.AssistantMessageResponseRole role,
            global::System.Collections.Generic.IList<global::G.ToolCallV2>? toolCalls,
            string? toolPlan,
            global::System.Collections.Generic.IList<global::G.ContentItem>? content,
            global::System.Collections.Generic.IList<global::G.Citation>? citations)
        {
            this.Role = role;
            this.ToolCalls = toolCalls;
            this.ToolPlan = toolPlan;
            this.Content = content;
            this.Citations = citations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageResponse" /> class.
        /// </summary>
        public AssistantMessageResponse()
        {
        }
    }
}