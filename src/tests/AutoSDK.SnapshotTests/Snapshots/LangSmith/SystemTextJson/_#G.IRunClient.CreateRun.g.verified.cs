//HintName: G.IRunClient.CreateRun.g.cs
#nullable enable

namespace G
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Create Run<br/>
        /// Create a new run.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateRunApiV1RunsPostResponse> CreateRunAsync(
            global::G.CreateRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Run<br/>
        /// Create a new run.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="inputs"></param>
        /// <param name="runType"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="extra"></param>
        /// <param name="error"></param>
        /// <param name="serialized"></param>
        /// <param name="outputs"></param>
        /// <param name="parentRunId"></param>
        /// <param name="events"></param>
        /// <param name="tags"></param>
        /// <param name="traceId"></param>
        /// <param name="dottedOrder"></param>
        /// <param name="id"></param>
        /// <param name="sessionId"></param>
        /// <param name="sessionName"></param>
        /// <param name="referenceExampleId"></param>
        /// <param name="inputAttachments"></param>
        /// <param name="outputAttachments"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateRunApiV1RunsPostResponse> CreateRunAsync(
            string name,
            global::G.CreateRunRequestRunType runType,
            object? inputs = default,
            global::G.OneOf<string, double?>? startTime = default,
            global::G.OneOf<string, double?>? endTime = default,
            object? extra = default,
            string? error = default,
            object? serialized = default,
            object? outputs = default,
            global::System.Guid? parentRunId = default,
            global::System.Collections.Generic.IList<object>? events = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Guid? traceId = default,
            string? dottedOrder = default,
            global::System.Guid? id = default,
            global::System.Guid? sessionId = default,
            string? sessionName = default,
            global::System.Guid? referenceExampleId = default,
            object? inputAttachments = default,
            object? outputAttachments = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}