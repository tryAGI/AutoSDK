//HintName: G.Models.ClientInboundMessageControl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientInboundMessageControl
    {
        /// <summary>
        /// This is the type of the message. Send "control" message to control the assistant. `control` options are:<br/>
        /// - "mute-assistant" - mute the assistant<br/>
        /// - "unmute-assistant" - unmute the assistant<br/>
        /// - "mute-customer" - mute the user<br/>
        /// - "unmute-customer" - unmute the user<br/>
        /// - "say-first-message" - say the first message (this is used when video recording is enabled and the conversation is only started once the client side kicks off the recording)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ClientInboundMessageControlTypeJsonConverter))]
        public global::G.ClientInboundMessageControlType Type { get; set; }

        /// <summary>
        /// This is the control action
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("control", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ClientInboundMessageControlControlJsonConverter))]
        public global::G.ClientInboundMessageControlControl Control { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInboundMessageControl" /> class.
        /// </summary>
        /// <param name="control">
        /// This is the control action
        /// </param>
        /// <param name="type">
        /// This is the type of the message. Send "control" message to control the assistant. `control` options are:<br/>
        /// - "mute-assistant" - mute the assistant<br/>
        /// - "unmute-assistant" - unmute the assistant<br/>
        /// - "mute-customer" - mute the user<br/>
        /// - "unmute-customer" - unmute the user<br/>
        /// - "say-first-message" - say the first message (this is used when video recording is enabled and the conversation is only started once the client side kicks off the recording)
        /// </param>
        public ClientInboundMessageControl(
            global::G.ClientInboundMessageControlControl control,
            global::G.ClientInboundMessageControlType type)
        {
            this.Type = type;
            this.Control = control;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInboundMessageControl" /> class.
        /// </summary>
        public ClientInboundMessageControl()
        {
        }
    }
}