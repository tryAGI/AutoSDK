//HintName: G.IFineTuningClient.DeleteFineTuning.g.cs
#nullable enable

namespace G
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Deletes an existing fine tuning by id This endpoint is in closed beta. [Contact us](https://groq.com/contact) for more information.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteFineTuningResponse> DeleteFineTuningAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}