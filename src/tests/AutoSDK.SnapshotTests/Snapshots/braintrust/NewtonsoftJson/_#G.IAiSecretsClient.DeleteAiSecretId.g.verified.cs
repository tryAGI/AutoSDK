//HintName: G.IAiSecretsClient.DeleteAiSecretId.g.cs
#nullable enable

namespace G
{
    public partial interface IAiSecretsClient
    {
        /// <summary>
        /// Delete ai_secret<br/>
        /// Delete an ai_secret object by its id
        /// </summary>
        /// <param name="aiSecretId">
        /// AiSecret id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AISecret> DeleteAiSecretIdAsync(
            global::System.Guid aiSecretId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}