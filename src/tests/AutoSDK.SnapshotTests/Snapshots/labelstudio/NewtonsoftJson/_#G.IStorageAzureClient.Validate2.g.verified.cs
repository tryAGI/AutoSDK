//HintName: G.IStorageAzureClient.Validate2.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageAzureClient
    {
        /// <summary>
        /// Validate export storage<br/>
        /// Validate a specific Azure export storage connection.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task Validate2Async(

            global::G.ApiStoragesExportAzureValidateCreateRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate export storage<br/>
        /// Validate a specific Azure export storage connection.
        /// </summary>
        /// <param name="accountKey">
        /// Azure Blob account key
        /// </param>
        /// <param name="accountName">
        /// Azure Blob account name
        /// </param>
        /// <param name="canDeleteObjects">
        /// Deletion from storage enabled<br/>
        /// Default Value: false
        /// </param>
        /// <param name="container">
        /// Azure blob container
        /// </param>
        /// <param name="description">
        /// Storage description
        /// </param>
        /// <param name="id">
        /// Storage ID. If set, storage with specified ID will be updated
        /// </param>
        /// <param name="prefix">
        /// Azure blob prefix name
        /// </param>
        /// <param name="project">
        /// Project ID
        /// </param>
        /// <param name="title">
        /// Storage title
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task Validate2Async(
            string? accountKey = default,
            string? accountName = default,
            bool? canDeleteObjects = default,
            string? container = default,
            string? description = default,
            int? id = default,
            string? prefix = default,
            int? project = default,
            string? title = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}