//HintName: G.IPromptClient.DeletePrompt.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeletePromptAsync(
            string promptId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}