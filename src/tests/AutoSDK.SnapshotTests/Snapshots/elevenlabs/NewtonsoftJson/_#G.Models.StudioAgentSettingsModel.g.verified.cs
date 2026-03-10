//HintName: G.Models.StudioAgentSettingsModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StudioAgentSettingsModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_settings")]
        public global::System.Collections.Generic.Dictionary<string, global::G.StudioAgentToolSettingsModel>? ToolSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StudioAgentSettingsModel" /> class.
        /// </summary>
        /// <param name="toolSettings"></param>
        public StudioAgentSettingsModel(
            global::System.Collections.Generic.Dictionary<string, global::G.StudioAgentToolSettingsModel>? toolSettings)
        {
            this.ToolSettings = toolSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StudioAgentSettingsModel" /> class.
        /// </summary>
        public StudioAgentSettingsModel()
        {
        }
    }
}