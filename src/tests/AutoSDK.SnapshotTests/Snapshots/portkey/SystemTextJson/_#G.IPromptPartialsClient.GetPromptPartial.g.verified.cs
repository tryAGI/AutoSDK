//HintName: G.IPromptPartialsClient.GetPromptPartial.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptPartialsClient
    {
        /// <summary>
        /// Get a prompt partial by ID or slug
        /// </summary>
        /// <param name="promptPartialId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptPartial> GetPromptPartialAsync(
            string promptPartialId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}