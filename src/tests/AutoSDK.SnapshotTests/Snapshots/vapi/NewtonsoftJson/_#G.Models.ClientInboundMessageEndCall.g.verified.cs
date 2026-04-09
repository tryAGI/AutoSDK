//HintName: G.Models.ClientInboundMessageEndCall.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientInboundMessageEndCall
    {
        /// <summary>
        /// This is the type of the message. Send "end-call" message to end the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ClientInboundMessageEndCallTypeJsonConverter))]
        public global::G.ClientInboundMessageEndCallType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInboundMessageEndCall" /> class.
        /// </summary>
        /// <param name="type">
        /// This is the type of the message. Send "end-call" message to end the call.
        /// </param>
        public ClientInboundMessageEndCall(
            global::G.ClientInboundMessageEndCallType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInboundMessageEndCall" /> class.
        /// </summary>
        public ClientInboundMessageEndCall()
        {
        }
    }
}