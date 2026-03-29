//HintName: G.Models.TransferDestinationSip.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferDestinationSip
    {
        /// <summary>
        /// This is spoken to the customer before connecting them to the destination.<br/>
        /// Usage:<br/>
        /// - If this is not provided and transfer tool messages is not provided, default is "Transferring the call now".<br/>
        /// - If set to "", nothing is spoken. This is useful when you want to silently transfer. This is especially useful when transferring between assistants in a squad. In this scenario, you likely also want to set `assistant.firstMessageMode=assistant-speaks-first-with-model-generated-message` for the destination assistant.<br/>
        /// This accepts a string or a ToolMessageStart class. Latter is useful if you want to specify multiple messages for different languages through the `contents` field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, global::G.CustomMessage>))]
        public global::G.OneOf<string, global::G.CustomMessage>? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TransferDestinationSipTypeJsonConverter))]
        public global::G.TransferDestinationSipType Type { get; set; }

        /// <summary>
        /// This is the SIP URI to transfer the call to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sipUri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SipUri { get; set; }

        /// <summary>
        /// This is the caller ID to use when transferring the call to the `sipUri`.<br/>
        /// Usage:<br/>
        /// - If not provided, the caller ID will be determined by the SIP infrastructure.<br/>
        /// - Set to '{{customer.number}}' to always use the customer's number as the caller ID.<br/>
        /// - Set to '{{phoneNumber.number}}' to always use the phone number of the assistant as the caller ID.<br/>
        /// - Set to any E164 number to always use that number as the caller ID.<br/>
        /// Only applicable when `transferPlan.sipVerb='dial'`. Not applicable for SIP REFER.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callerId")]
        public string? CallerId { get; set; }

        /// <summary>
        /// This configures how transfer is executed and the experience of the destination party receiving the call. Defaults to `blind-transfer`.<br/>
        /// @default `transferPlan.mode='blind-transfer'`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transferPlan")]
        public global::G.TransferPlan? TransferPlan { get; set; }

        /// <summary>
        /// These are custom headers to be added to SIP refer during transfer call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sipHeaders")]
        public object? SipHeaders { get; set; }

        /// <summary>
        /// This is the description of the destination, used by the AI to choose when and how to transfer the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferDestinationSip" /> class.
        /// </summary>
        /// <param name="sipUri">
        /// This is the SIP URI to transfer the call to.
        /// </param>
        /// <param name="message">
        /// This is spoken to the customer before connecting them to the destination.<br/>
        /// Usage:<br/>
        /// - If this is not provided and transfer tool messages is not provided, default is "Transferring the call now".<br/>
        /// - If set to "", nothing is spoken. This is useful when you want to silently transfer. This is especially useful when transferring between assistants in a squad. In this scenario, you likely also want to set `assistant.firstMessageMode=assistant-speaks-first-with-model-generated-message` for the destination assistant.<br/>
        /// This accepts a string or a ToolMessageStart class. Latter is useful if you want to specify multiple messages for different languages through the `contents` field.
        /// </param>
        /// <param name="type"></param>
        /// <param name="callerId">
        /// This is the caller ID to use when transferring the call to the `sipUri`.<br/>
        /// Usage:<br/>
        /// - If not provided, the caller ID will be determined by the SIP infrastructure.<br/>
        /// - Set to '{{customer.number}}' to always use the customer's number as the caller ID.<br/>
        /// - Set to '{{phoneNumber.number}}' to always use the phone number of the assistant as the caller ID.<br/>
        /// - Set to any E164 number to always use that number as the caller ID.<br/>
        /// Only applicable when `transferPlan.sipVerb='dial'`. Not applicable for SIP REFER.
        /// </param>
        /// <param name="transferPlan">
        /// This configures how transfer is executed and the experience of the destination party receiving the call. Defaults to `blind-transfer`.<br/>
        /// @default `transferPlan.mode='blind-transfer'`
        /// </param>
        /// <param name="sipHeaders">
        /// These are custom headers to be added to SIP refer during transfer call.
        /// </param>
        /// <param name="description">
        /// This is the description of the destination, used by the AI to choose when and how to transfer the call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferDestinationSip(
            string sipUri,
            global::G.OneOf<string, global::G.CustomMessage>? message,
            global::G.TransferDestinationSipType type,
            string? callerId,
            global::G.TransferPlan? transferPlan,
            object? sipHeaders,
            string? description)
        {
            this.Message = message;
            this.Type = type;
            this.SipUri = sipUri ?? throw new global::System.ArgumentNullException(nameof(sipUri));
            this.CallerId = callerId;
            this.TransferPlan = transferPlan;
            this.SipHeaders = sipHeaders;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferDestinationSip" /> class.
        /// </summary>
        public TransferDestinationSip()
        {
        }
    }
}