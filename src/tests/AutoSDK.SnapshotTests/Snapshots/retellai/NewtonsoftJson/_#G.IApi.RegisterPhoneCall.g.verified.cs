//HintName: G.IApi.RegisterPhoneCall.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Register a new phone call for custom telephony
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.V2PhoneCallResponse> RegisterPhoneCallAsync(

            global::G.RegisterPhoneCallRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register a new phone call for custom telephony
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.V2PhoneCallResponse> RegisterPhoneCallAsync(
            string agentId,
            int? agentVersion = default,
            global::G.AgentOverrideRequest? agentOverride = default,
            string? fromNumber = default,
            string? toNumber = default,
            global::G.RegisterPhoneCallRequestDirection? direction = default,
            object? metadata = default,
            object? retellLlmDynamicVariables = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}