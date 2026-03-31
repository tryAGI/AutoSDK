//HintName: G.ICorsClient.OptionsAiSecret.g.cs
#nullable enable

namespace G
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/ai_secret`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsAiSecretAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}