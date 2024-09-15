//HintName: G.IRunClient.UpdateRun.g.cs
#nullable enable

namespace G
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Update Run<br/>
        /// Update a run.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateRunApiV1RunsRunIdPatchResponse> UpdateRunAsync(
            global::System.Guid runId,
            global::G.UpdateRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Run<br/>
        /// Update a run.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="traceId"></param>
        /// <param name="dottedOrder"></param>
        /// <param name="parentRunId"></param>
        /// <param name="endTime"></param>
        /// <param name="error"></param>
        /// <param name="inputs"></param>
        /// <param name="outputs"></param>
        /// <param name="events"></param>
        /// <param name="tags"></param>
        /// <param name="extra"></param>
        /// <param name="inputAttachments"></param>
        /// <param name="outputAttachments"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateRunApiV1RunsRunIdPatchResponse> UpdateRunAsync(
            global::System.Guid runId,
            global::G.OneOf<global::System.Guid?, object>? traceId = default,
            global::G.OneOf<string, object>? dottedOrder = default,
            global::G.OneOf<global::System.Guid?, object>? parentRunId = default,
            global::G.OneOf<string, double?, object>? endTime = default,
            global::G.OneOf<string, object>? error = default,
            global::G.OneOf<global::G.UpdateRunRequestInputs, object>? inputs = default,
            global::G.OneOf<global::G.UpdateRunRequestOutputs, object>? outputs = default,
            global::G.OneOf<global::System.Collections.Generic.IList<global::G.UpdateRunRequestEventsVariant1Item>, object>? events = default,
            global::G.OneOf<global::System.Collections.Generic.IList<string>, object>? tags = default,
            global::G.OneOf<global::G.UpdateRunRequestExtra, object>? extra = default,
            global::G.OneOf<global::G.UpdateRunRequestInputAttachments, object>? inputAttachments = default,
            global::G.OneOf<global::G.UpdateRunRequestOutputAttachments, object>? outputAttachments = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}