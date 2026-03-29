//HintName: G.Models.McpServerCapabilitiesCounts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpServerCapabilitiesCounts
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::G.McpServerCapabilitiesCountsTools? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts")]
        public global::G.McpServerCapabilitiesCountsPrompts? Prompts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::G.McpServerCapabilitiesCountsResources? Resources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_templates")]
        public global::G.McpServerCapabilitiesCountsResourceTemplates? ResourceTemplates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerCapabilitiesCounts" /> class.
        /// </summary>
        /// <param name="tools"></param>
        /// <param name="prompts"></param>
        /// <param name="resources"></param>
        /// <param name="resourceTemplates"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpServerCapabilitiesCounts(
            global::G.McpServerCapabilitiesCountsTools? tools,
            global::G.McpServerCapabilitiesCountsPrompts? prompts,
            global::G.McpServerCapabilitiesCountsResources? resources,
            global::G.McpServerCapabilitiesCountsResourceTemplates? resourceTemplates)
        {
            this.Tools = tools;
            this.Prompts = prompts;
            this.Resources = resources;
            this.ResourceTemplates = resourceTemplates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerCapabilitiesCounts" /> class.
        /// </summary>
        public McpServerCapabilitiesCounts()
        {
        }
    }
}