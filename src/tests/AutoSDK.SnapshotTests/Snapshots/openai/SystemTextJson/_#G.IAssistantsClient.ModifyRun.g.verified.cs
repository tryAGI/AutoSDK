//HintName: G.IAssistantsClient.ModifyRun.g.cs
#nullable enable

namespace G
{
    public partial interface IAssistantsClient
    {
        /// <summary>
        /// Modifies a run.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "G_BETA_001")]
        global::System.Threading.Tasks.Task<global::G.RunObject> ModifyRunAsync(
            string threadId,
            string runId,
            global::G.ModifyRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Modifies a run.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="runId"></param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maximum of 512 characters long.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "G_BETA_001")]
        global::System.Threading.Tasks.Task<global::G.RunObject> ModifyRunAsync(
            string threadId,
            string runId,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}