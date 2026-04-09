//HintName: G.IEvalClient.EvalControllerCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IEvalClient
    {
        /// <summary>
        /// Create Eval
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Eval> EvalControllerCreateAsync(

            global::G.CreateEvalDTO request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Eval
        /// </summary>
        /// <param name="messages">
        /// This is the mock conversation that will be used to evaluate the flow of the conversation.<br/>
        /// Mock Messages are used to simulate the flow of the conversation<br/>
        /// Evaluation Messages are used as checkpoints in the flow where the model's response to previous conversation needs to be evaluated to check the content and tool calls<br/>
        /// Example: [{ role: "user", content: "Hello, how are you?" }, { role: "assistant", judgePlan: { type: "exact", content: "I am good, thank you!" } }]
        /// </param>
        /// <param name="name">
        /// This is the name of the eval.<br/>
        /// It helps identify what the eval is checking for.<br/>
        /// Example: Verified User Flow Eval
        /// </param>
        /// <param name="description">
        /// This is the description of the eval.<br/>
        /// This helps describe the eval and its purpose in detail. It will not be used to evaluate the flow of the conversation.<br/>
        /// Example: This eval checks if the user flow is verified.
        /// </param>
        /// <param name="type">
        /// This is the type of the eval.<br/>
        /// Currently it is fixed to `chat.mockConversation`.<br/>
        /// Example: chat.mockConversation
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Eval> EvalControllerCreateAsync(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.ChatEvalAssistantMessageMock, global::G.ChatEvalSystemMessageMock, global::G.ChatEvalToolResponseMessageMock, global::G.ChatEvalToolResponseMessageEvaluation, global::G.ChatEvalUserMessageMock, global::G.ChatEvalAssistantMessageEvaluation>> messages,
            string? name = default,
            string? description = default,
            global::G.CreateEvalDTOType type = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}