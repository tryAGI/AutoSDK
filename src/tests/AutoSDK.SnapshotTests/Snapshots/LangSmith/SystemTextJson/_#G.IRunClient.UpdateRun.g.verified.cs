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
        global::System.Threading.Tasks.Task<string> UpdateRunAsync(
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
        /// <param name="sessionId"></param>
        /// <param name="sessionName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateRunAsync(
            global::System.Guid runId,
            global::System.Guid? traceId = default,
            string? dottedOrder = default,
            global::System.Guid? parentRunId = default,
            global::G.OneOf<string, double?>? endTime = default,
            string? error = default,
            object? inputs = default,
            object? outputs = default,
            global::System.Collections.Generic.IList<object>? events = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            object? extra = default,
            object? inputAttachments = default,
            object? outputAttachments = default,
            global::System.Guid? sessionId = default,
            string? sessionName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}