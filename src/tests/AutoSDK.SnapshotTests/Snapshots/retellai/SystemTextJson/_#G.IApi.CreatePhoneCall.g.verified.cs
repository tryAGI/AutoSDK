//HintName: G.IApi.CreatePhoneCall.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create a new outbound phone call
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.V2PhoneCallResponse> CreatePhoneCallAsync(

            global::G.CreatePhoneCallRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new outbound phone call
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.V2PhoneCallResponse> CreatePhoneCallAsync(
            string fromNumber,
            string toNumber,
            string? overrideAgentId = default,
            int? overrideAgentVersion = default,
            global::G.AgentOverrideRequest? agentOverride = default,
            object? metadata = default,
            object? retellLlmDynamicVariables = default,
            global::System.Collections.Generic.Dictionary<string, string>? customSipHeaders = default,
            bool? ignoreE164Validation = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}