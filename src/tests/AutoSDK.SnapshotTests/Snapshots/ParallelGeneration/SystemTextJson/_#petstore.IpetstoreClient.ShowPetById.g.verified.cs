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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::petstore.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::petstore.Pet> ShowPetByIdAsync(
            string petId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}