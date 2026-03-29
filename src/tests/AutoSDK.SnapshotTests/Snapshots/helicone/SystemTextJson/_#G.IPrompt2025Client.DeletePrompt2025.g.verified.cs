//HintName: G.IPrompt2025Client.DeletePrompt2025.g.cs
#nullable enable

namespace G
{
    public partial interface IPrompt2025Client
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNullString> DeletePrompt2025Async(
            string promptId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}