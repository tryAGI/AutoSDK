//HintName: G.Models.GetToolRouterSessionBySessionIdResponseExperimental.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Experimental features
    /// </summary>
    public sealed partial class GetToolRouterSessionBySessionIdResponseExperimental
    {
        /// <summary>
        /// The assistive system prompt for the tool router session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistive_prompt")]
        public string? AssistivePrompt { get; set; }

        /// <summary>
        /// User-defined custom toolkits with grouped tools (no-auth)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_toolkits")]
        public global::System.Collections.Generic.IList<global::G.GetToolRouterSessionBySessionIdResponseExperimentalCustomToolkit>? CustomToolkits { get; set; }

        /// <summary>
        /// Custom tools — standalone or extending Composio toolkits
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_tools")]
        public global::System.Collections.Generic.IList<global::G.GetToolRouterSessionBySessionIdResponseExperimentalCustomTool>? CustomTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseExperimental" /> class.
        /// </summary>
        /// <param name="assistivePrompt">
        /// The assistive system prompt for the tool router session
        /// </param>
        /// <param name="customToolkits">
        /// User-defined custom toolkits with grouped tools (no-auth)
        /// </param>
        /// <param name="customTools">
        /// Custom tools — standalone or extending Composio toolkits
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetToolRouterSessionBySessionIdResponseExperimental(
            string? assistivePrompt,
            global::System.Collections.Generic.IList<global::G.GetToolRouterSessionBySessionIdResponseExperimentalCustomToolkit>? customToolkits,
            global::System.Collections.Generic.IList<global::G.GetToolRouterSessionBySessionIdResponseExperimentalCustomTool>? customTools)
        {
            this.AssistivePrompt = assistivePrompt;
            this.CustomToolkits = customToolkits;
            this.CustomTools = customTools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseExperimental" /> class.
        /// </summary>
        public GetToolRouterSessionBySessionIdResponseExperimental()
        {
        }
    }
}