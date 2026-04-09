//HintName: G.Models.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsTypeJsonConverter))]
        public global::G.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_disabled")]
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// If omitted, all tools are enabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled_tools")]
        public global::System.Collections.Generic.IList<string>? EnabledTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="isDisabled"></param>
        /// <param name="enabledTools">
        /// If omitted, all tools are enabled
        /// </param>
        public PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions(
            global::System.Guid id,
            global::G.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType type,
            bool? isDisabled,
            global::System.Collections.Generic.IList<string>? enabledTools)
        {
            this.Type = type;
            this.Id = id;
            this.IsDisabled = isDisabled;
            this.EnabledTools = enabledTools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions" /> class.
        /// </summary>
        public PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions()
        {
        }
    }
}