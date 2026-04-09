//HintName: G.Models.TransferDestinationNumber.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferDestinationNumber
    {
        /// <summary>
        /// This is spoken to the customer before connecting them to the destination.<br/>
        /// Usage:<br/>
        /// - If this is not provided and transfer tool messages is not provided, default is "Transferring the call now".<br/>
        /// - If set to "", nothing is spoken. This is useful when you want to silently transfer. This is especially useful when transferring between assistants in a squad. In this scenario, you likely also want to set `assistant.firstMessageMode=assistant-speaks-first-with-model-generated-message` for the destination assistant.<br/>
        /// This accepts a string or a ToolMessageStart class. Latter is useful if you want to specify multiple messages for different languages through the `contents` field.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public global::G.OneOf<string, global::G.CustomMessage>? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TransferDestinationNumberTypeJsonConverter))]
        public global::G.TransferDestinationNumberType Type { get; set; }

        /// <summary>
        /// This is the flag to toggle the E164 check for the `number` field. This is an advanced property which should be used if you know your use case requires it.<br/>
        /// Use cases:<br/>
        /// - `false`: To allow non-E164 numbers like `+001234567890`, `1234`, or `abc`. This is useful for dialing out to non-E164 numbers on your SIP trunks.<br/>
        /// - `true` (default): To allow only E164 numbers like `+14155551234`. This is standard for PSTN calls.<br/>
        /// If `false`, the `number` is still required to only contain alphanumeric characters (regex: `/^\+?[a-zA-Z0-9]+$/`).<br/>
        /// @default true (E164 check is enabled)<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("numberE164CheckEnabled")]
        public bool? NumberE164CheckEnabled { get; set; }

        /// <summary>
        /// This is the phone number to transfer the call to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public string Number { get; set; } = default!;

        /// <summary>
        /// This is the extension to dial after transferring the call to the `number`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extension")]
        public string? Extension { get; set; }

        /// <summary>
        /// This is the caller ID to use when transferring the call to the `number`.<br/>
        /// Usage:<br/>
        /// - If not provided, the caller ID will be the number the call is coming **from**.<br/>
        ///   Example: a customer with number +14151111111 calls in to and the assistant transfers out to +16470000000. +16470000000 will see +14151111111 as the caller.<br/>
        ///   For inbound calls, the caller ID is the customer's number. For outbound calls, the caller ID is the phone number of the assistant.<br/>
        /// - To change this behavior, provide a `callerId`.<br/>
        /// - Set to '{{customer.number}}' to always use the customer's number as the caller ID.<br/>
        /// - Set to '{{phoneNumber.number}}' to always use the phone number of the assistant as the caller ID.<br/>
        /// - Set to any E164 number to always use that number as the caller ID. This needs to be a number that is owned or verified by your Transport provider like Twilio.<br/>
        /// For Twilio, you can read up more here: https://www.twilio.com/docs/voice/twiml/dial#callerid
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callerId")]
        public string? CallerId { get; set; }

        /// <summary>
        /// This configures how transfer is executed and the experience of the destination party receiving the call. Defaults to `blind-transfer`.<br/>
        /// @default `transferPlan.mode='blind-transfer'`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transferPlan")]
        public global::G.TransferPlan? TransferPlan { get; set; }

        /// <summary>
        /// This is the description of the destination, used by the AI to choose when and how to transfer the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferDestinationNumber" /> class.
        /// </summary>
        /// <param name="number">
        /// This is the phone number to transfer the call to.
        /// </param>
        /// <param name="message">
        /// This is spoken to the customer before connecting them to the destination.<br/>
        /// Usage:<br/>
        /// - If this is not provided and transfer tool messages is not provided, default is "Transferring the call now".<br/>
        /// - If set to "", nothing is spoken. This is useful when you want to silently transfer. This is especially useful when transferring between assistants in a squad. In this scenario, you likely also want to set `assistant.firstMessageMode=assistant-speaks-first-with-model-generated-message` for the destination assistant.<br/>
        /// This accepts a string or a ToolMessageStart class. Latter is useful if you want to specify multiple messages for different languages through the `contents` field.
        /// </param>
        /// <param name="type"></param>
        /// <param name="numberE164CheckEnabled">
        /// This is the flag to toggle the E164 check for the `number` field. This is an advanced property which should be used if you know your use case requires it.<br/>
        /// Use cases:<br/>
        /// - `false`: To allow non-E164 numbers like `+001234567890`, `1234`, or `abc`. This is useful for dialing out to non-E164 numbers on your SIP trunks.<br/>
        /// - `true` (default): To allow only E164 numbers like `+14155551234`. This is standard for PSTN calls.<br/>
        /// If `false`, the `number` is still required to only contain alphanumeric characters (regex: `/^\+?[a-zA-Z0-9]+$/`).<br/>
        /// @default true (E164 check is enabled)<br/>
        /// Default Value: true
        /// </param>
        /// <param name="extension">
        /// This is the extension to dial after transferring the call to the `number`.
        /// </param>
        /// <param name="callerId">
        /// This is the caller ID to use when transferring the call to the `number`.<br/>
        /// Usage:<br/>
        /// - If not provided, the caller ID will be the number the call is coming **from**.<br/>
        ///   Example: a customer with number +14151111111 calls in to and the assistant transfers out to +16470000000. +16470000000 will see +14151111111 as the caller.<br/>
        ///   For inbound calls, the caller ID is the customer's number. For outbound calls, the caller ID is the phone number of the assistant.<br/>
        /// - To change this behavior, provide a `callerId`.<br/>
        /// - Set to '{{customer.number}}' to always use the customer's number as the caller ID.<br/>
        /// - Set to '{{phoneNumber.number}}' to always use the phone number of the assistant as the caller ID.<br/>
        /// - Set to any E164 number to always use that number as the caller ID. This needs to be a number that is owned or verified by your Transport provider like Twilio.<br/>
        /// For Twilio, you can read up more here: https://www.twilio.com/docs/voice/twiml/dial#callerid
        /// </param>
        /// <param name="transferPlan">
        /// This configures how transfer is executed and the experience of the destination party receiving the call. Defaults to `blind-transfer`.<br/>
        /// @default `transferPlan.mode='blind-transfer'`
        /// </param>
        /// <param name="description">
        /// This is the description of the destination, used by the AI to choose when and how to transfer the call.
        /// </param>
        public TransferDestinationNumber(
            string number,
            global::G.OneOf<string, global::G.CustomMessage>? message,
            global::G.TransferDestinationNumberType type,
            bool? numberE164CheckEnabled,
            string? extension,
            string? callerId,
            global::G.TransferPlan? transferPlan,
            string? description)
        {
            this.Message = message;
            this.Type = type;
            this.NumberE164CheckEnabled = numberE164CheckEnabled;
            this.Number = number ?? throw new global::System.ArgumentNullException(nameof(number));
            this.Extension = extension;
            this.CallerId = callerId;
            this.TransferPlan = transferPlan;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferDestinationNumber" /> class.
        /// </summary>
        public TransferDestinationNumber()
        {
        }
    }
}