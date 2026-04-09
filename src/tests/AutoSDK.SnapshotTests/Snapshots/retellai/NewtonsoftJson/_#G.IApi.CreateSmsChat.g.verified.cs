//HintName: G.IApi.CreateSmsChat.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Start an outbound SMS chat conversation with a phone number using the specified agent. The agent must be configured for chat mode. The initial SMS message will be automatically generated and sent based on the agent's configuration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatResponse> CreateSmsChatAsync(

            global::G.CreateSmsChatRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start an outbound SMS chat conversation with a phone number using the specified agent. The agent must be configured for chat mode. The initial SMS message will be automatically generated and sent based on the agent's configuration.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatResponse> CreateSmsChatAsync(
            string fromNumber,
            string toNumber,
            string? overrideAgentId = default,
            int? overrideAgentVersion = default,
            object? metadata = default,
            object? retellLlmDynamicVariables = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}