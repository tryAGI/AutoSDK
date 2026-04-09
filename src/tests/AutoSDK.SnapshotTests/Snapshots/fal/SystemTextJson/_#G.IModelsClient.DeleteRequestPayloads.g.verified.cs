//HintName: G.IModelsClient.DeleteRequestPayloads.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Delete request payloads<br/>
        /// Deletes the IO payloads and associated CDN output files for a specific request.<br/>
        /// **Important:**<br/>
        /// - Only **output** CDN files are deleted (input files may be used by other requests)<br/>
        /// - This action is irreversible<br/>
        /// - Requires authentication with an admin API key<br/>
        /// **What gets deleted:**<br/>
        /// - Request input/output payload data<br/>
        /// - CDN-hosted output files (images, videos, etc.)<br/>
        /// **What is NOT deleted:**<br/>
        /// - Input CDN files (may be referenced by other requests)<br/>
        /// **Response:**<br/>
        /// - Returns deletion status for each CDN file<br/>
        /// - Each result includes the file link and any error that occurred<br/>
        /// **Idempotency:**<br/>
        /// - Optional Idempotency-Key header prevents duplicate deletions on retries<br/>
        /// - Responses cached for 10 minutes per unique key<br/>
        /// See [fal.ai docs](https://docs.fal.ai/model-apis/payloads) for more details about request payloads.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for the request (UUID format)<br/>
        /// Example: a1b2c3d4-e5f6-7890-abcd-ef1234567890
        /// </param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteRequestPayloadsResponse> DeleteRequestPayloadsAsync(
            global::System.Guid requestId,
            string? idempotencyKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}