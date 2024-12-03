//HintName: G.IApi.ListPets.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// List all pets
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Pet>> ListPetsAsync(
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}