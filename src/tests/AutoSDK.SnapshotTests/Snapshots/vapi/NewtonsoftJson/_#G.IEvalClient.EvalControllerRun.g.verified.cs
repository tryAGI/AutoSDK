//HintName: G.IEvalClient.EvalControllerRun.g.cs
#nullable enable

namespace G
{
    public partial interface IEvalClient
    {
        /// <summary>
        /// Create Eval Run
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> EvalControllerRunAsync(

            global::G.CreateEvalRunDTO request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Eval Run
        /// </summary>
        /// <param name="eval">
        /// This is the transient eval that will be run
        /// </param>
        /// <param name="target">
        /// This is the target that will be run against the eval
        /// </param>
        /// <param name="type">
        /// This is the type of the run.<br/>
        /// Currently it is fixed to `eval`.<br/>
        /// Example: eval
        /// </param>
        /// <param name="evalId">
        /// This is the id of the eval that will be run.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> EvalControllerRunAsync(
            global::G.OneOf<global::G.EvalRunTargetAssistant, global::G.EvalRunTargetSquad> target,
            global::G.CreateEvalDTO? eval = default,
            global::G.CreateEvalRunDTOType type = default,
            string? evalId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}