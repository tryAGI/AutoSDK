//HintName: G.IPromptClient.GetPromptVersion.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="promptVersionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPromptVersionResultString> GetPromptVersionAsync(
            string promptVersionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}