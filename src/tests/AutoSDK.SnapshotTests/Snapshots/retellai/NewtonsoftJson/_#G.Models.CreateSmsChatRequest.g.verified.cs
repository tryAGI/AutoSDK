//HintName: G.Models.CreateSmsChatRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSmsChatRequest
    {
        /// <summary>
        /// The phone number to send SMS from in E.164 format. Must be a number purchased from Retell or imported to Retell with SMS capability.<br/>
        /// Example: +12137771234
        /// </summary>
        /// <example>+12137771234</example>
        [global::Newtonsoft.Json.JsonProperty("from_number", Required = global::Newtonsoft.Json.Required.Always)]
        public string FromNumber { get; set; } = default!;

        /// <summary>
        /// The phone number to send SMS to in E.164 format<br/>
        /// Example: +14155551234
        /// </summary>
        /// <example>+14155551234</example>
        [global::Newtonsoft.Json.JsonProperty("to_number", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToNumber { get; set; } = default!;

        /// <summary>
        /// For this particular chat, override the agent used with this agent id. This does not bind the agent to this number, this is for one time override.<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </summary>
        /// <example>oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD</example>
        [global::Newtonsoft.Json.JsonProperty("override_agent_id")]
        public string? OverrideAgentId { get; set; }

        /// <summary>
        /// For this particular chat, override the agent version used with this version. This does not bind the agent version to this number, this is for one time override.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("override_agent_version")]
        public int? OverrideAgentVersion { get; set; }

        /// <summary>
        /// An arbitrary object for storage purpose only. You can put anything here like your internal customer id associated with the chat. Not used for processing. You can later get this field from the chat object.
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
        /// Initializes a new instance of the <see cref="CreateSmsChatRequest" /> class.
        /// </summary>
        /// <param name="fromNumber">
        /// The phone number to send SMS from in E.164 format. Must be a number purchased from Retell or imported to Retell with SMS capability.<br/>
        /// Example: +12137771234
        /// </param>
        /// <param name="toNumber">
        /// The phone number to send SMS to in E.164 format<br/>
        /// Example: +14155551234
        /// </param>
        /// <param name="overrideAgentId">
        /// For this particular chat, override the agent used with this agent id. This does not bind the agent to this number, this is for one time override.<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </param>
        /// <param name="overrideAgentVersion">
        /// For this particular chat, override the agent version used with this version. This does not bind the agent version to this number, this is for one time override.<br/>
        /// Example: 1
        /// </param>
        /// <param name="metadata">
        /// An arbitrary object for storage purpose only. You can put anything here like your internal customer id associated with the chat. Not used for processing. You can later get this field from the chat object.
        /// </param>
        /// <param name="retellLlmDynamicVariables">
        /// Add optional dynamic variables in key value pairs of string that injects into your Response Engine prompt and tool description. Only applicable for Response Engine.<br/>
        /// Example: {"customer_name":"John Doe"}
        /// </param>
        public CreateSmsChatRequest(
            string fromNumber,
            string toNumber,
            string? overrideAgentId,
            int? overrideAgentVersion,
            object? metadata,
            object? retellLlmDynamicVariables)
        {
            this.FromNumber = fromNumber ?? throw new global::System.ArgumentNullException(nameof(fromNumber));
            this.ToNumber = toNumber ?? throw new global::System.ArgumentNullException(nameof(toNumber));
            this.OverrideAgentId = overrideAgentId;
            this.OverrideAgentVersion = overrideAgentVersion;
            this.Metadata = metadata;
            this.RetellLlmDynamicVariables = retellLlmDynamicVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSmsChatRequest" /> class.
        /// </summary>
        public CreateSmsChatRequest()
        {
        }
    }
}