//HintName: petstore.IpetstoreClient.ShowPetById.g.cs
#nullable enable

namespace petstore
{
    public partial interface IpetstoreClient
    {
        /// <summary>
        /// Info for a specific pet
        /// </summary>
        /// <param name="petId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::petstore.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::petstore.Pet> ShowPetByIdAsync(
            string petId,
            global::petstore.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}