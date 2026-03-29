//HintName: G.Models.TransferCallNodeVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferCallNodeVariant2
    {
        /// <summary>
        /// Type of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TransferCallNodeVariant2TypeJsonConverter))]
        public global::G.TransferCallNodeVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TransferDestinationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TransferDestination TransferDestination { get; set; }

        /// <summary>
        /// If true, the e.164 validation will be ignored for the from_number. This can be useful when you want to dial to internal pseudo numbers. This only applies when you are using custom telephony and does not apply when you are using Retell Telephony. If omitted, the default value is false.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore_e164_validation")]
        public bool? IgnoreE164Validation { get; set; }

        /// <summary>
        /// Custom SIP headers for transfer calls
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_sip_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? CustomSipHeaders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_option")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TransferOptionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TransferOption TransferOption { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edge")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TransferFailedEdgeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TransferFailedEdge Edge { get; set; }

        /// <summary>
        /// If true, will speak during execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speak_during_execution")]
        public bool? SpeakDuringExecution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.NodeInstructionJsonConverter))]
        public global::G.NodeInstruction? Instruction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferCallNodeVariant2" /> class.
        /// </summary>
        /// <param name="transferDestination"></param>
        /// <param name="transferOption"></param>
        /// <param name="edge"></param>
        /// <param name="type">
        /// Type of the node
        /// </param>
        /// <param name="ignoreE164Validation">
        /// If true, the e.164 validation will be ignored for the from_number. This can be useful when you want to dial to internal pseudo numbers. This only applies when you are using custom telephony and does not apply when you are using Retell Telephony. If omitted, the default value is false.<br/>
        /// Example: false
        /// </param>
        /// <param name="customSipHeaders">
        /// Custom SIP headers for transfer calls
        /// </param>
        /// <param name="speakDuringExecution">
        /// If true, will speak during execution
        /// </param>
        /// <param name="instruction"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferCallNodeVariant2(
            global::G.TransferDestination transferDestination,
            global::G.TransferOption transferOption,
            global::G.TransferFailedEdge edge,
            global::G.TransferCallNodeVariant2Type type,
            bool? ignoreE164Validation,
            global::System.Collections.Generic.Dictionary<string, string>? customSipHeaders,
            bool? speakDuringExecution,
            global::G.NodeInstruction? instruction)
        {
            this.Type = type;
            this.TransferDestination = transferDestination;
            this.IgnoreE164Validation = ignoreE164Validation;
            this.CustomSipHeaders = customSipHeaders;
            this.TransferOption = transferOption;
            this.Edge = edge;
            this.SpeakDuringExecution = speakDuringExecution;
            this.Instruction = instruction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferCallNodeVariant2" /> class.
        /// </summary>
        public TransferCallNodeVariant2()
        {
        }
    }
}