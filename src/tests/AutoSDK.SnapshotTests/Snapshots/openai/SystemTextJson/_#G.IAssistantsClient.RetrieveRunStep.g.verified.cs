//HintName: G.IAssistantsClient.RetrieveRunStep.g.cs
#nullable enable

namespace G
{
    public partial interface IAssistantsClient
    {
        /// <summary>
        /// Retrieves a run step.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="runId"></param>
        /// <param name="stepId"></param>
        /// <param name="include"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RunStepObject> RetrieveRunStepAsync(
            string threadId,
            string runId,
            string stepId,
            global::System.Collections.Generic.IList<global::G.GetRunStepIncludeItem>? include = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}