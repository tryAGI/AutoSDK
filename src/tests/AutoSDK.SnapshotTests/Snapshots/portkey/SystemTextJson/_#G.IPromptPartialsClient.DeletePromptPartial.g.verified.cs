//HintName: G.IPromptPartialsClient.DeletePromptPartial.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptPartialsClient
    {
        /// <summary>
        /// Delete a prompt partial
        /// </summary>
        /// <param name="promptPartialId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeletePromptPartialAsync(
            string promptPartialId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}