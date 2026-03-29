//HintName: G.IPrompt2025Client.DeletePrompt2025Version.g.cs
#nullable enable

namespace G
{
    public partial interface IPrompt2025Client
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="versionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNullString> DeletePrompt2025VersionAsync(
            string promptId,
            string versionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}