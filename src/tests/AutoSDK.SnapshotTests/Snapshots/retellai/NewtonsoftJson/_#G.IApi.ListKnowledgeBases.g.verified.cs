//HintName: G.IApi.ListKnowledgeBases.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// List all knowledge bases
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.KnowledgeBaseResponse>> ListKnowledgeBasesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}