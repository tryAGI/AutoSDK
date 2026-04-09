//HintName: G.Models.TransferCallTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferCallTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TransferCallToolTypeJsonConverter))]
        public global::G.TransferCallToolType Type { get; set; }

        /// <summary>
        /// Name of the tool. Must be unique within all tools available to LLM at any given time (general tools + state tools + state edges).<br/>
        /// Example: transfer_to_support
        /// </summary>
        /// <example>transfer_to_support</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Describes what the tool does, sometimes can also include information about when to call the tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transfer_destination", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TransferDestination TransferDestination { get; set; } = default!;

        /// <summary>
        /// If true, the e.164 validation will be ignored for the from_number. This can be useful when you want to dial to internal pseudo numbers. This only applies when you are using custom telephony and does not apply when you are using Retell Telephony. If omitted, the default value is false.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("ignore_e164_validation")]
        public bool? IgnoreE164Validation { get; set; }

        /// <summary>
        /// Custom SIP headers to be added to the call.<br/>
        /// Example: {"X-Custom-Header":"Custom Value"}
        /// </summary>
        /// <example>{"X-Custom-Header":"Custom Value"}</example>
        [global::Newtonsoft.Json.JsonProperty("custom_sip_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? CustomSipHeaders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transfer_option", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TransferOption TransferOption { get; set; } = default!;

        /// <summary>
        /// If true, will speak during execution.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speak_during_execution")]
        public bool? SpeakDuringExecution { get; set; }

        /// <summary>
        /// Describes what to say to user when transferring the call. Only applicable when speak_during_execution is true.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution_message_description")]
        public string? ExecutionMessageDescription { get; set; }

        /// <summary>
        /// Type of execution message. "prompt" means the agent will use execution_message_description as a prompt to generate the message. "static_text" means the agent will speak the execution_message_description directly. Defaults to "prompt".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution_message_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TransferCallToolExecutionMessageTypeJsonConverter))]
        public global::G.TransferCallToolExecutionMessageType? ExecutionMessageType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferCallTool" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the tool. Must be unique within all tools available to LLM at any given time (general tools + state tools + state edges).<br/>
        /// Example: transfer_to_support
        /// </param>
        /// <param name="transferDestination"></param>
        /// <param name="transferOption"></param>
        /// <param name="type"></param>
        /// <param name="description">
        /// Describes what the tool does, sometimes can also include information about when to call the tool.
        /// </param>
        /// <param name="ignoreE164Validation">
        /// If true, the e.164 validation will be ignored for the from_number. This can be useful when you want to dial to internal pseudo numbers. This only applies when you are using custom telephony and does not apply when you are using Retell Telephony. If omitted, the default value is false.<br/>
        /// Example: false
        /// </param>
        /// <param name="customSipHeaders">
        /// Custom SIP headers to be added to the call.<br/>
        /// Example: {"X-Custom-Header":"Custom Value"}
        /// </param>
        /// <param name="speakDuringExecution">
        /// If true, will speak during execution.
        /// </param>
        /// <param name="executionMessageDescription">
        /// Describes what to say to user when transferring the call. Only applicable when speak_during_execution is true.
        /// </param>
        /// <param name="executionMessageType">
        /// Type of execution message. "prompt" means the agent will use execution_message_description as a prompt to generate the message. "static_text" means the agent will speak the execution_message_description directly. Defaults to "prompt".
        /// </param>
        public TransferCallTool(
            string name,
            global::G.TransferDestination transferDestination,
            global::G.TransferOption transferOption,
            global::G.TransferCallToolType type,
            string? description,
            bool? ignoreE164Validation,
            global::System.Collections.Generic.Dictionary<string, string>? customSipHeaders,
            bool? speakDuringExecution,
            string? executionMessageDescription,
            global::G.TransferCallToolExecutionMessageType? executionMessageType)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.TransferDestination = transferDestination;
            this.IgnoreE164Validation = ignoreE164Validation;
            this.CustomSipHeaders = customSipHeaders;
            this.TransferOption = transferOption;
            this.SpeakDuringExecution = speakDuringExecution;
            this.ExecutionMessageDescription = executionMessageDescription;
            this.ExecutionMessageType = executionMessageType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferCallTool" /> class.
        /// </summary>
        public TransferCallTool()
        {
        }
    }
}