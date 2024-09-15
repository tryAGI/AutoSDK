//HintName: G.IApi.CreatePets.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create a pet
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Error> CreatePetsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}