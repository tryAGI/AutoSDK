﻿//HintName: G.IAssistantsClient.ListRunSteps.g.cs
#nullable enable

namespace G
{
    public partial interface IAssistantsClient
    {
        /// <summary>
        /// Returns a list of run steps belonging to a run.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="runId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="include"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "G_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::G.ListRunStepsResponse> ListRunStepsAsync(
            string threadId,
            string runId,
            int? limit = default,
            global::G.ListRunStepsOrder? order = default,
            string? after = default,
            string? before = default,
            global::System.Collections.Generic.IList<global::G.ListRunStepsIncludeItem>? include = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}