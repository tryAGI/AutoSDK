//HintName: G.IExperimentClient.CreateNewExperimentTable.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultTableIdStringExperimentIdStringString> CreateNewExperimentTableAsync(

            global::G.CreateExperimentTableParams request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="experimentMetadata">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="promptVersionId"></param>
        /// <param name="newHeliconeTemplate"></param>
        /// <param name="isMajorVersion"></param>
        /// <param name="promptSubversionMetadata">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="experimentTableMetadata">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultTableIdStringExperimentIdStringString> CreateNewExperimentTableAsync(
            string datasetId,
            global::G.RecordStringAny experimentMetadata,
            string promptVersionId,
            string newHeliconeTemplate,
            bool isMajorVersion,
            global::G.RecordStringAny promptSubversionMetadata,
            global::G.RecordStringAny? experimentTableMetadata = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}