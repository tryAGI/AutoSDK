//HintName: G.Models.TransferHookAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferHookAction
    {
        /// <summary>
        /// This is the type of action - must be "transfer"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TransferHookActionTypeJsonConverter))]
        public global::G.TransferHookActionType Type { get; set; }

        /// <summary>
        /// This is the destination details for the transfer - can be a phone number or SIP URI
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("destination")]
        public global::G.OneOf<global::G.TransferDestinationNumber, global::G.TransferDestinationSip>? Destination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferHookAction" /> class.
        /// </summary>
        /// <param name="type">
        /// This is the type of action - must be "transfer"
        /// </param>
        /// <param name="destination">
        /// This is the destination details for the transfer - can be a phone number or SIP URI
        /// </param>
        public TransferHookAction(
            global::G.TransferHookActionType type,
            global::G.OneOf<global::G.TransferDestinationNumber, global::G.TransferDestinationSip>? destination)
        {
            this.Type = type;
            this.Destination = destination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferHookAction" /> class.
        /// </summary>
        public TransferHookAction()
        {
        }
    }
}