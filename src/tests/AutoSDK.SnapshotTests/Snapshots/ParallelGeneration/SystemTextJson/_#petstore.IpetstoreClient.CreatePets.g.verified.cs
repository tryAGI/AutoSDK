//HintName: petstore.IpetstoreClient.CreatePets.g.cs
#nullable enable

namespace petstore
{
    public partial interface IpetstoreClient
    {
        /// <summary>
        /// Create a pet
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::petstore.ApiException"></exception>
        global::System.Threading.Tasks.Task CreatePetsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}