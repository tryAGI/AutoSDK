//HintName: G.Ix__ModelClient.ModelPublicServiceTriggerAsyncNamespaceModel.g.cs
#nullable enable

namespace G
{
    public partial interface Ix__ModelClient
    {
        /// <summary>
        /// Trigger model inference asynchronously<br/>
        /// Triggers a deployed model to infer the result of a set of task or<br/>
        /// questions.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="modelId"></param>
        /// <param name="version"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TriggerAsyncNamespaceModelResponse> ModelPublicServiceTriggerAsyncNamespaceModelAsync(
            string namespaceId,
            string modelId,
            string version,
            global::G.TriggerAsyncNamespaceModelBody request,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Trigger model inference asynchronously<br/>
        /// Triggers a deployed model to infer the result of a set of task or<br/>
        /// questions.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="modelId"></param>
        /// <param name="version"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="taskInputs">
        /// Model inference inputs.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TriggerAsyncNamespaceModelResponse> ModelPublicServiceTriggerAsyncNamespaceModelAsync(
            string namespaceId,
            string modelId,
            string version,
            global::System.Collections.Generic.IList<object> taskInputs,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}