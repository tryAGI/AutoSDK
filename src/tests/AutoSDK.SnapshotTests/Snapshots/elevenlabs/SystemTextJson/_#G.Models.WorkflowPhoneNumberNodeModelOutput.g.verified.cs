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
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_sip_headers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CustomSipHeadersItem3> CustomSipHeaders { get; set; }

        /// <summary>
        /// Default Value: phone_number
        /// </summary>
        /// <default>"phone_number"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "phone_number";

        /// <summary>
        /// Position of the node in the workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PositionOutput Position { get; set; }

        /// <summary>
        /// The ids of outgoing edges in the order they should be evaluated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edge_order")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> EdgeOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TransferDestination2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TransferDestination2 TransferDestination { get; set; }

        /// <summary>
        /// Default Value: conference
        /// </summary>
        /// <default>global::G.TransferTypeEnum.Conference</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TransferTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TransferTypeEnum TransferType { get; set; } = global::G.TransferTypeEnum.Conference;

        /// <summary>
        /// DTMF digits to send after call connects (e.g., 'ww1234' for extension). Can be either a static value or a dynamic variable reference. Use 'w' for 0.5s pause.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post_dial_digits")]
        public global::G.PostDialDigitsVariant13? PostDialDigits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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