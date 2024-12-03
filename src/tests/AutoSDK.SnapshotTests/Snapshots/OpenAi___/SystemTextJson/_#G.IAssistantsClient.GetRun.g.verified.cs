//HintName: G.IAssistantsClient.GetRun.g.cs
#nullable enable

namespace G
{
    public partial interface IAssistantsClient
    {
        /// <summary>
        /// Retrieves a run.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "G_BETA_001")]
        global::System.Threading.Tasks.Task<global::G.RunObject> GetRunAsync(
            string threadId,
            string runId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}