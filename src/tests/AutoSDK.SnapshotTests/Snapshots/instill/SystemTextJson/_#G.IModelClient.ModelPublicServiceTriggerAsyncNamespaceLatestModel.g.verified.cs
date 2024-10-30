//HintName: G.IModelClient.ModelPublicServiceTriggerAsyncNamespaceLatestModel.g.cs
#nullable enable

namespace G
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Trigger model inference asynchronously<br/>
        /// Triggers the latest deployed model version to infer the result of a set of task or<br/>
        /// questions.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="modelId"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TriggerAsyncNamespaceLatestModelResponse> ModelPublicServiceTriggerAsyncNamespaceLatestModelAsync(
            string namespaceId,
            string modelId,
            global::G.TriggerAsyncNamespaceLatestModelBody request,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Trigger model inference asynchronously<br/>
        /// Triggers the latest deployed model version to infer the result of a set of task or<br/>
        /// questions.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="modelId"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="taskInputs">
        /// Model inference inputs.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TriggerAsyncNamespaceLatestModelResponse> ModelPublicServiceTriggerAsyncNamespaceLatestModelAsync(
            string namespaceId,
            string modelId,
            global::System.Collections.Generic.IList<object> taskInputs,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}