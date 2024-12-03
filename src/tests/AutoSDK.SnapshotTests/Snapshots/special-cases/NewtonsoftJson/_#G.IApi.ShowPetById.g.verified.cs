//HintName: G.IApi.ShowPetById.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Info for a specific pet
        /// </summary>
        /// <param name="petId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Pet> ShowPetByIdAsync(
            string petId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}