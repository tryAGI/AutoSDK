//HintName: G.Models.WorkflowPhoneNumberNodeModelInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowPhoneNumberNodeModelInput
    {
        /// <summary>
        /// Custom SIP headers to include when transferring the call. Each header can be either a static value or a dynamic variable reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_sip_headers")]
        public global::System.Collections.Generic.IList<global::G.CustomSipHeadersItem2>? CustomSipHeaders { get; set; }

        /// <summary>
        /// Default Value: phone_number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Position of the node in the workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public global::G.PositionInput? Position { get; set; }

        /// <summary>
        /// The ids of outgoing edges in the order they should be evaluated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edge_order")]
        public global::System.Collections.Generic.IList<string>? EdgeOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TransferDestinationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TransferDestination TransferDestination { get; set; }

        /// <summary>
        /// Default Value: conference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TransferTypeEnumJsonConverter))]
        public global::G.TransferTypeEnum? TransferType { get; set; }

        /// <summary>
        /// DTMF digits to send after call connects (e.g., 'ww1234' for extension). Can be either a static value or a dynamic variable reference. Use 'w' for 0.5s pause.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post_dial_digits")]
        public global::G.PostDialDigitsVariant12? PostDialDigits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowPhoneNumberNodeModelInput" /> class.
        /// </summary>
        /// <param name="transferDestination"></param>
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
        /// <param name="transferType">
        /// Default Value: conference
        /// </param>
        /// <param name="postDialDigits">
        /// DTMF digits to send after call connects (e.g., 'ww1234' for extension). Can be either a static value or a dynamic variable reference. Use 'w' for 0.5s pause.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowPhoneNumberNodeModelInput(
            global::G.TransferDestination transferDestination,
            global::System.Collections.Generic.IList<global::G.CustomSipHeadersItem2>? customSipHeaders,
            string? type,
            global::G.PositionInput? position,
            global::System.Collections.Generic.IList<string>? edgeOrder,
            global::G.TransferTypeEnum? transferType,
            global::G.PostDialDigitsVariant12? postDialDigits)
        {
            this.CustomSipHeaders = customSipHeaders;
            this.Type = type;
            this.Position = position;
            this.EdgeOrder = edgeOrder;
            this.TransferDestination = transferDestination;
            this.TransferType = transferType;
            this.PostDialDigits = postDialDigits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowPhoneNumberNodeModelInput" /> class.
        /// </summary>
        public WorkflowPhoneNumberNodeModelInput()
        {
        }
    }
}