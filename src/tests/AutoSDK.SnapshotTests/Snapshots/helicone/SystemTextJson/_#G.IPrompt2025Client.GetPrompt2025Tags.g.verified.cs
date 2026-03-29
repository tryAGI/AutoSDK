//HintName: G.IPrompt2025Client.GetPrompt2025Tags.g.cs
#nullable enable

namespace G
{
    public partial interface IPrompt2025Client
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultStringArrayString> GetPrompt2025TagsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}