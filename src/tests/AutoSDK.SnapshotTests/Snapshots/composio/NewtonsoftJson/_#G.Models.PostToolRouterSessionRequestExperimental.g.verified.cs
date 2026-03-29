//HintName: G.Models.PostToolRouterSessionRequestExperimental.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Experimental features - not stable, may be modified or removed in future versions.
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestExperimental
    {
        /// <summary>
        /// Customize assistive prompt generation (e.g., timezone).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistive_prompt_config")]
        public global::G.PostToolRouterSessionRequestExperimentalAssistivePromptConfig? AssistivePromptConfig { get; set; }

        /// <summary>
        /// Custom toolkits with grouped tools. Toolkit slugs must not conflict with existing Composio toolkits. All tools are no-auth.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_toolkits")]
        public global::System.Collections.Generic.IList<global::G.PostToolRouterSessionRequestExperimentalCustomToolkit>? CustomToolkits { get; set; }

        /// <summary>
        /// Custom tools to include in search. Standalone tools need no auth. Tools with extends_toolkit inherit the Composio toolkit's connection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_tools")]
        public global::System.Collections.Generic.IList<global::G.PostToolRouterSessionRequestExperimentalCustomTool>? CustomTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestExperimental" /> class.
        /// </summary>
        /// <param name="assistivePromptConfig">
        /// Customize assistive prompt generation (e.g., timezone).
        /// </param>
        /// <param name="customToolkits">
        /// Custom toolkits with grouped tools. Toolkit slugs must not conflict with existing Composio toolkits. All tools are no-auth.
        /// </param>
        /// <param name="customTools">
        /// Custom tools to include in search. Standalone tools need no auth. Tools with extends_toolkit inherit the Composio toolkit's connection.
        /// </param>
        public PostToolRouterSessionRequestExperimental(
            global::G.PostToolRouterSessionRequestExperimentalAssistivePromptConfig? assistivePromptConfig,
            global::System.Collections.Generic.IList<global::G.PostToolRouterSessionRequestExperimentalCustomToolkit>? customToolkits,
            global::System.Collections.Generic.IList<global::G.PostToolRouterSessionRequestExperimentalCustomTool>? customTools)
        {
            this.AssistivePromptConfig = assistivePromptConfig;
            this.CustomToolkits = customToolkits;
            this.CustomTools = customTools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestExperimental" /> class.
        /// </summary>
        public PostToolRouterSessionRequestExperimental()
        {
        }
    }
}