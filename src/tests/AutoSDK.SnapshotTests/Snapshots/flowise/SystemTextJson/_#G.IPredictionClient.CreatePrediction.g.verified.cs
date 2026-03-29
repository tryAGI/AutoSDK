//HintName: G.IPredictionClient.CreatePrediction.g.cs
#nullable enable

namespace G
{
    public partial interface IPredictionClient
    {
        /// <summary>
        /// Send message to flow and get AI response<br/>
        /// Send a message to your flow and receive an AI-generated response. This is the primary endpoint for interacting with your flows and assistants.<br/>
        /// **Authentication**: API key may be required depending on flow settings.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePredictionResponse> CreatePredictionAsync(
            string id,

            global::G.Prediction request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send message to flow and get AI response<br/>
        /// Send a message to your flow and receive an AI-generated response. This is the primary endpoint for interacting with your flows and assistants.<br/>
        /// **Authentication**: API key may be required depending on flow settings.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="question">
        /// The question/message to send to the flow<br/>
        /// Example: What is artificial intelligence?
        /// </param>
        /// <param name="form">
        /// The form object to send to the flow (alternative to question for Agentflow V2)<br/>
        /// Example: {"title":"Example","count":1}
        /// </param>
        /// <param name="streaming">
        /// Enable streaming responses for real-time output<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="overrideConfig">
        /// Override flow configuration and pass variables at runtime<br/>
        /// Example: {"sessionId":"user-session-123","temperature":0.7,"maxTokens":500,"vars":{"user_name":"Alice"}}
        /// </param>
        /// <param name="history">
        /// Previous conversation messages for context<br/>
        /// Example: [{"role":"apiMessage","content":"Hello! I\u0027m an AI assistant. How can I help you today?"}, {"role":"userMessage","content":"Hi, my name is Sarah and I\u0027m learning about AI"}]
        /// </param>
        /// <param name="uploads">
        /// Files to upload (images, audio, documents, etc.)<br/>
        /// Example: [{"type":"file","name":"example.png","data":"data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAABjElEQVRIS\u002B2Vv0oDQRDG","mime":"image/png"}]
        /// </param>
        /// <param name="humanInput">
        /// Return human feedback and resume execution from a stopped checkpoint<br/>
        /// Example: {"type":"reject","feedback":"Include more emoji"}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePredictionResponse> CreatePredictionAsync(
            string id,
            string? question = default,
            object? form = default,
            bool? streaming = default,
            object? overrideConfig = default,
            global::System.Collections.Generic.IList<global::G.PredictionHistoryItem>? history = default,
            global::System.Collections.Generic.IList<global::G.PredictionUpload>? uploads = default,
            global::G.PredictionHumanInput? humanInput = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}