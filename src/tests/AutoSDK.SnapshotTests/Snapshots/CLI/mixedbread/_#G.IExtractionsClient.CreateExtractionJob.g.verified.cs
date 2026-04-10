//HintName: G.IExtractionsClient.CreateExtractionJob.g.cs
#nullable enable

namespace G
{
    public partial interface IExtractionsClient
    {
        /// <summary>
        /// Start an extraction job<br/>
        /// Start an extraction job for the provided file and schema.<br/>
        /// Args:<br/>
        ///     params: The parameters for creating an extraction job.<br/>
        /// Returns:<br/>
        ///     The created extraction job.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExtractionJob> CreateExtractionJobAsync(

            global::G.ExtractJobCreateParams request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start an extraction job<br/>
        /// Start an extraction job for the provided file and schema.<br/>
        /// Args:<br/>
        ///     params: The parameters for creating an extraction job.<br/>
        /// Returns:<br/>
        ///     The created extraction job.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the file to extract from
        /// </param>
        /// <param name="jsonSchema">
        /// The JSON schema to use for extraction
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExtractionJob> CreateExtractionJobAsync(
            string fileId,
            object jsonSchema,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}