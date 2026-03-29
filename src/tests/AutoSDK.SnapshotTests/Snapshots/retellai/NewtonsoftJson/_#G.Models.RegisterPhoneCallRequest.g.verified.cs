//HintName: G.Models.RegisterPhoneCallRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegisterPhoneCallRequest
    {
        /// <summary>
        /// The agent to use for the call.<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </summary>
        /// <example>oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD</example>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// The version of the agent to use for the call.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("agent_version")]
        public int? AgentVersion { get; set; }

        /// <summary>
        /// Override configuration for agent, retell LLM, or conversation flow settings for a specific call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_override")]
        public global::G.AgentOverrideRequest? AgentOverride { get; set; }

        /// <summary>
        /// The number you own in E.164 format. Stored for tracking purpose.<br/>
        /// Example: +14157774444
        /// </summary>
        /// <example>+14157774444</example>
        [global::Newtonsoft.Json.JsonProperty("from_number")]
        public string? FromNumber { get; set; }

        /// <summary>
        /// The number you want to call, in E.164 format. Stored for tracking purpose.<br/>
        /// Example: +12137774445
        /// </summary>
        /// <example>+12137774445</example>
        [global::Newtonsoft.Json.JsonProperty("to_number")]
        public string? ToNumber { get; set; }

        /// <summary>
        /// Direction of the phone call. Stored for tracking purpose.<br/>
        /// Example: inbound
        /// </summary>
        /// <example>inbound</example>
        [global::Newtonsoft.Json.JsonProperty("direction")]
        public global::G.RegisterPhoneCallRequestDirection? Direction { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterPhoneCallRequest" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The agent to use for the call.<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </param>
        /// <param name="agentVersion">
        /// The version of the agent to use for the call.<br/>
        /// Example: 1
        /// </param>
        /// <param name="agentOverride">
        /// Override configuration for agent, retell LLM, or conversation flow settings for a specific call.
        /// </param>
        /// <param name="fromNumber">
        /// The number you own in E.164 format. Stored for tracking purpose.<br/>
        /// Example: +14157774444
        /// </param>
        /// <param name="toNumber">
        /// The number you want to call, in E.164 format. Stored for tracking purpose.<br/>
        /// Example: +12137774445
        /// </param>
        /// <param name="direction">
        /// Direction of the phone call. Stored for tracking purpose.<br/>
        /// Example: inbound
        /// </param>
        /// <param name="metadata">
        /// An arbitrary object for storage purpose only. You can put anything here like your internal customer id associated with the call. Not used for processing. You can later get this field from the call object.
        /// </param>
        /// <param name="retellLlmDynamicVariables">
        /// Add optional dynamic variables in key value pairs of string that injects into your Response Engine prompt and tool description. Only applicable for Response Engine.<br/>
        /// Example: {"customer_name":"John Doe"}
        /// </param>
        public RegisterPhoneCallRequest(
            string agentId,
            int? agentVersion,
            global::G.AgentOverrideRequest? agentOverride,
            string? fromNumber,
            string? toNumber,
            global::G.RegisterPhoneCallRequestDirection? direction,
            object? metadata,
            object? retellLlmDynamicVariables)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentVersion = agentVersion;
            this.AgentOverride = agentOverride;
            this.FromNumber = fromNumber;
            this.ToNumber = toNumber;
            this.Direction = direction;
            this.Metadata = metadata;
            this.RetellLlmDynamicVariables = retellLlmDynamicVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterPhoneCallRequest" /> class.
        /// </summary>
        public RegisterPhoneCallRequest()
        {
        }
    }
}