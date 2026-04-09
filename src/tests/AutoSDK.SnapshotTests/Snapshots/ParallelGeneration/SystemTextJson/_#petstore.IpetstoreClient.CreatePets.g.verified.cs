//HintName: petstore.IpetstoreClient.CreatePets.g.cs
#nullable enable

namespace petstore
{
    public partial interface IpetstoreClient
    {
        /// <summary>
        /// Create a pet
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::petstore.ApiException"></exception>
        global::System.Threading.Tasks.Task CreatePetsAsync(
            global::petstore.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}