//HintName: G.IExperimentsClient.ExperimentItemsBulk.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Record experiment items in bulk<br/>
        /// Record experiment items in bulk with traces, spans, and feedback scores. Maximum request size is 4MB.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ExperimentItemsBulkAsync(

            global::G.ExperimentItemBulkUploadExperimentItemBulkWriteView request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Record experiment items in bulk<br/>
        /// Record experiment items in bulk with traces, spans, and feedback scores. Maximum request size is 4MB.
        /// </summary>
        /// <param name="experimentName"></param>
        /// <param name="datasetName"></param>
        /// <param name="experimentId">
        /// Optional experiment ID. If provided, items will be added to the existing experiment and experimentName will be ignored. If not provided or experiment with that ID doesn't exist, a new experiment will be created with the given experimentName
        /// </param>
        /// <param name="items"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ExperimentItemsBulkAsync(
            string experimentName,
            string datasetName,
            global::System.Collections.Generic.IList<global::G.ExperimentItemBulkRecordExperimentItemBulkWriteView> items,
            global::System.Guid? experimentId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}