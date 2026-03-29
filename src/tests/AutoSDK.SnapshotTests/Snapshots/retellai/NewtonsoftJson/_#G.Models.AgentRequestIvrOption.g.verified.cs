//HintName: G.Models.AgentRequestIvrOption.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If this option is set, the call will try to detect IVR in the first 3 minutes of the call. Actions defined will be applied when the IVR is detected. Set this to null to disable IVR detection.<br/>
    /// Example: {"action":{"type":"hangup"}}
    /// </summary>
    public sealed partial class AgentRequestIvrOption
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.IvrActionHangup Action { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRequestIvrOption" /> class.
        /// </summary>
        /// <param name="action"></param>
        public AgentRequestIvrOption(
            global::G.IvrActionHangup action)
        {
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRequestIvrOption" /> class.
        /// </summary>
        public AgentRequestIvrOption()
        {
        }
    }
}