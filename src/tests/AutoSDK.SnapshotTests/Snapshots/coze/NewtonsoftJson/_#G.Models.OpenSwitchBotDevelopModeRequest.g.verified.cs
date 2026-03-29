//HintName: G.Models.OpenSwitchBotDevelopModeRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenSwitchBotDevelopModeRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collaboration_mode")]
        public global::G.OpenSwitchBotDevelopModeRequestCollaborationMode? CollaborationMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenSwitchBotDevelopModeRequest" /> class.
        /// </summary>
        /// <param name="collaborationMode"></param>
        public OpenSwitchBotDevelopModeRequest(
            global::G.OpenSwitchBotDevelopModeRequestCollaborationMode? collaborationMode)
        {
            this.CollaborationMode = collaborationMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenSwitchBotDevelopModeRequest" /> class.
        /// </summary>
        public OpenSwitchBotDevelopModeRequest()
        {
        }
    }
}