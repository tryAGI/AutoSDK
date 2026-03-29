//HintName: G.ISubpackageGenerationsClient.GetGeneration.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageGenerationsClient
    {
        /// <summary>
        /// Get request &amp; usage metadata for a generation
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GenerationsGetGenerationResponse200> GetGenerationAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}