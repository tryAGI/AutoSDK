//HintName: G.IDescriptorClient.GetConvertFieldTypeJobResponse.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// GetConvertFieldTypeJobResponse<br/>
        /// GetConvertFieldTypeJobResponse
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetConvertFieldTypeJobResponseAsync(
            global::G.GetConvertFieldTypeJobResponseRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetConvertFieldTypeJobResponse<br/>
        /// GetConvertFieldTypeJobResponse
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetConvertFieldTypeJobResponseAsync(
            global::System.Guid jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}