//HintName: G.IAssistantsClient.GetRunStep.g.cs
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RunStepObject> GetRunStepAsync(
            string threadId,
            string runId,
            string stepId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}