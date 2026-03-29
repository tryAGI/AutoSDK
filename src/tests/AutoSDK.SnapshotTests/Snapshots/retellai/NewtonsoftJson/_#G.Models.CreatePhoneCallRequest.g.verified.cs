//HintName: G.Models.CreatePhoneCallRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePhoneCallRequest
    {
        /// <summary>
        /// The number you own in E.164 format. Must be a number purchased from Retell or imported to Retell.<br/>
        /// Example: +14157774444
        /// </summary>
        /// <example>+14157774444</example>
        [global::Newtonsoft.Json.JsonProperty("from_number", Required = global::Newtonsoft.Json.Required.Always)]
        public string FromNumber { get; set; } = default!;

        /// <summary>
        /// The number you want to call, in E.164 format. If using a number purchased from Retell, only US numbers are supported as destination.<br/>
        /// Example: +12137774445
        /// </summary>
        /// <example>+12137774445</example>
        [global::Newtonsoft.Json.JsonProperty("to_number", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToNumber { get; set; } = default!;

        /// <summary>
        /// For this particular call, override the agent used with this agent id. This does not bind the agent to this number, this is for one time override.<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </summary>
        /// <example>oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD</example>
        [global::Newtonsoft.Json.JsonProperty("override_agent_id")]
        public string? OverrideAgentId { get; set; }

        /// <summary>
        /// For this particular call, override the agent version used with this version. This does not bind the agent version to this number, this is for one time override.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("override_agent_version")]
        public int? OverrideAgentVersion { get; set; }

        /// <summary>
        /// Override configuration for agent, retell LLM, or conversation flow settings for a specific call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_override")]
        public global::G.AgentOverrideRequest? AgentOverride { get; set; }

        /// <summary>
        /// An arbitrary object for storage purpose only. You can put anything here like your internal customer id associated with the call. Not used for processing. You can later get this field from the call object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Add optional dynamic variables in key value pairs of string that injects into your Response Engine prompt and tool description. Only applicable for Response Engine.<br/>
        /// Example: {"customer_name":"John Doe"}
        /// </summary>
        /// <example>{"customer_name":"John Doe"}</example>
        [global::Newtonsoft.Json.JsonProperty("retell_llm_dynamic_variables")]
        public object? RetellLlmDynamicVariables { get; set; }

        /// <summary>
        /// Add optional custom SIP headers to the call.<br/>
        /// Example: {"X-Custom-Header":"Custom Value"}
        /// </summary>
        /// <example>{"X-Custom-Header":"Custom Value"}</example>
        [global::Newtonsoft.Json.JsonProperty("custom_sip_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? CustomSipHeaders { get; set; }

        /// <summary>
        /// If true, the e.164 validation will be ignored for the from_number. This can be useful when you want to dial to internal pseudo numbers. This only applies when you are using custom telephony and does not apply when you are using Retell Telephony. If omitted, the default value is false.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("ignore_e164_validation")]
        public bool? IgnoreE164Validation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePhoneCallRequest" /> class.
        /// </summary>
        /// <param name="fromNumber">
        /// The number you own in E.164 format. Must be a number purchased from Retell or imported to Retell.<br/>
        /// Example: +14157774444
        /// </param>
        /// <param name="toNumber">
        /// The number you want to call, in E.164 format. If using a number purchased from Retell, only US numbers are supported as destination.<br/>
        /// Example: +12137774445
        /// </param>
        /// <param name="overrideAgentId">
        /// For this particular call, override the agent used with this agent id. This does not bind the agent to this number, this is for one time override.<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </param>
        /// <param name="overrideAgentVersion">
        /// For this particular call, override the agent version used with this version. This does not bind the agent version to this number, this is for one time override.<br/>
        /// Example: 1
        /// </param>
        /// <param name="agentOverride">
        /// Override configuration for agent, retell LLM, or conversation flow settings for a specific call.
        /// </param>
        /// <param name="metadata">
        /// An arbitrary object for storage purpose only. You can put anything here like your internal customer id associated with the call. Not used for processing. You can later get this field from the call object.
        /// </param>
        /// <param name="retellLlmDynamicVariables">
        /// Add optional dynamic variables in key value pairs of string that injects into your Response Engine prompt and tool description. Only applicable for Response Engine.<br/>
        /// Example: {"customer_name":"John Doe"}
        /// </param>
        /// <param name="customSipHeaders">
        /// Add optional custom SIP headers to the call.<br/>
        /// Example: {"X-Custom-Header":"Custom Value"}
        /// </param>
        /// <param name="ignoreE164Validation">
        /// If true, the e.164 validation will be ignored for the from_number. This can be useful when you want to dial to internal pseudo numbers. This only applies when you are using custom telephony and does not apply when you are using Retell Telephony. If omitted, the default value is false.<br/>
        /// Example: true
        /// </param>
        public CreatePhoneCallRequest(
            string fromNumber,
            string toNumber,
            string? overrideAgentId,
            int? overrideAgentVersion,
            global::G.AgentOverrideRequest? agentOverride,
            object? metadata,
            object? retellLlmDynamicVariables,
            global::System.Collections.Generic.Dictionary<string, string>? customSipHeaders,
            bool? ignoreE164Validation)
        {
            this.FromNumber = fromNumber ?? throw new global::System.ArgumentNullException(nameof(fromNumber));
            this.ToNumber = toNumber ?? throw new global::System.ArgumentNullException(nameof(toNumber));
            this.OverrideAgentId = overrideAgentId;
            this.OverrideAgentVersion = overrideAgentVersion;
            this.AgentOverride = agentOverride;
            this.Metadata = metadata;
            this.RetellLlmDynamicVariables = retellLlmDynamicVariables;
            this.CustomSipHeaders = customSipHeaders;
            this.IgnoreE164Validation = ignoreE164Validation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePhoneCallRequest" /> class.
        /// </summary>
        public CreatePhoneCallRequest()
        {
        }
    }
}