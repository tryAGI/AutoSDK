//HintName: G.Models.WorkflowPhoneNumberNodeModelOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowPhoneNumberNodeModelOutput
    {
        /// <summary>
        /// Custom SIP headers to include when transferring the call. Each header can be either a static value or a dynamic variable reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_sip_headers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CustomSipHeadersItem3> CustomSipHeaders { get; set; } = default!;

        /// <summary>
        /// Default Value: phone_number
        /// </summary>
        /// <default>"phone_number"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "phone_number";

        /// <summary>
        /// Position of the node in the workflow.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PositionOutput Position { get; set; } = default!;

        /// <summary>
        /// The ids of outgoing edges in the order they should be evaluated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("edge_order", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> EdgeOrder { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transfer_destination", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TransferDestination2 TransferDestination { get; set; } = default!;

        /// <summary>
        /// Default Value: conference
        /// </summary>
        /// <default>global::G.TransferTypeEnum.Conference</default>
        [global::Newtonsoft.Json.JsonProperty("transfer_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TransferTypeEnum TransferType { get; set; } = default!;

        /// <summary>
        /// DTMF digits to send after call connects (e.g., 'ww1234' for extension). Can be either a static value or a dynamic variable reference. Use 'w' for 0.5s pause.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("post_dial_digits")]
        public global::G.PostDialDigitsVariant13? PostDialDigits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowPhoneNumberNodeModelOutput" /> class.
        /// </summary>
        /// <param name="customSipHeaders">
        /// Custom SIP headers to include when transferring the call. Each header can be either a static value or a dynamic variable reference.
        /// </param>
        /// <param name="type">
        /// Default Value: phone_number
        /// </param>
        /// <param name="position">
        /// Position of the node in the workflow.
        /// </param>
        /// <param name="edgeOrder">
        /// The ids of outgoing edges in the order they should be evaluated.
        /// </param>
        /// <param name="transferDestination"></param>
        /// <param name="transferType">
        /// Default Value: conference
        /// </param>
        /// <param name="postDialDigits">
        /// DTMF digits to send after call connects (e.g., 'ww1234' for extension). Can be either a static value or a dynamic variable reference. Use 'w' for 0.5s pause.
        /// </param>
        public WorkflowPhoneNumberNodeModelOutput(
            global::System.Collections.Generic.IList<global::G.CustomSipHeadersItem3> customSipHeaders,
            global::G.PositionOutput position,
            global::System.Collections.Generic.IList<string> edgeOrder,
            global::G.TransferDestination2 transferDestination,
            global::G.TransferTypeEnum transferType,
            global::G.PostDialDigitsVariant13? postDialDigits,
            string type = "phone_number")
        {
            this.CustomSipHeaders = customSipHeaders ?? throw new global::System.ArgumentNullException(nameof(customSipHeaders));
            this.Position = position ?? throw new global::System.ArgumentNullException(nameof(position));
            this.EdgeOrder = edgeOrder ?? throw new global::System.ArgumentNullException(nameof(edgeOrder));
            this.TransferDestination = transferDestination;
            this.TransferType = transferType;
            this.Type = type;
            this.PostDialDigits = postDialDigits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowPhoneNumberNodeModelOutput" /> class.
        /// </summary>
        public WorkflowPhoneNumberNodeModelOutput()
        {
        }
    }
}