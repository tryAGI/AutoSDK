//HintName: G.Models.McpIntegrationCapabilitiesCounts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpIntegrationCapabilitiesCounts
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::G.McpIntegrationCapabilitiesCountsTools? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompts")]
        public global::G.McpIntegrationCapabilitiesCountsPrompts? Prompts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resources")]
        public global::G.McpIntegrationCapabilitiesCountsResources? Resources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resource_templates")]
        public global::G.McpIntegrationCapabilitiesCountsResourceTemplates? ResourceTemplates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpIntegrationCapabilitiesCounts" /> class.
        /// </summary>
        /// <param name="tools"></param>
        /// <param name="prompts"></param>
        /// <param name="resources"></param>
        /// <param name="resourceTemplates"></param>
        public McpIntegrationCapabilitiesCounts(
            global::G.McpIntegrationCapabilitiesCountsTools? tools,
            global::G.McpIntegrationCapabilitiesCountsPrompts? prompts,
            global::G.McpIntegrationCapabilitiesCountsResources? resources,
            global::G.McpIntegrationCapabilitiesCountsResourceTemplates? resourceTemplates)
        {
            this.Tools = tools;
            this.Prompts = prompts;
            this.Resources = resources;
            this.ResourceTemplates = resourceTemplates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpIntegrationCapabilitiesCounts" /> class.
        /// </summary>
        public McpIntegrationCapabilitiesCounts()
        {
        }
    }
}