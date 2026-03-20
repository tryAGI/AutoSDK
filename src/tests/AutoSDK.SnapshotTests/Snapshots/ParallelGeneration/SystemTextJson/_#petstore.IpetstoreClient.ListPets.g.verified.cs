//HintName: petstore.IpetstoreClient.ListPets.g.cs
#nullable enable

namespace petstore
{
    public partial interface IpetstoreClient
    {
        /// <summary>
        /// List all pets
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::petstore.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::petstore.Pet>> ListPetsAsync(
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}