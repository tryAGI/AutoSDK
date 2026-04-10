//HintName: G.IApi.ModelAddLegacyStartDatasetIdVersionIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Model Add Legacy<br/>
        /// Starts a model inference session.<br/>
        /// This endpoint initializes and starts an inference session for the specified model version.<br/>
        /// Args:<br/>
        ///     dataset_id (str): ID of a Roboflow dataset corresponding to the model.<br/>
        ///     version_id (str): ID of a Roboflow dataset version corresponding to the model.<br/>
        ///     api_key (str, optional): Roboflow API Key for artifact retrieval.<br/>
        ///     countinference (Optional[bool]): Whether to count inference or not.<br/>
        ///     service_secret (Optional[str]): The service secret for the request.<br/>
        /// Returns:<br/>
        ///     JSONResponse: A response object containing the status and a success message.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="versionId"></param>
        /// <param name="apiKey"></param>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ModelAddLegacyStartDatasetIdVersionIdGetAsync(
            string datasetId,
            string versionId,
            string? apiKey = default,
            bool? countinference = default,
            string? serviceSecret = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}