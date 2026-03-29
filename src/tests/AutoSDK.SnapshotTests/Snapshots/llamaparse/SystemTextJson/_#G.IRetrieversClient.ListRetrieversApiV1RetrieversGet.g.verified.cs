//HintName: G.IRetrieversClient.ListRetrieversApiV1RetrieversGet.g.cs
#nullable enable

namespace G
{
    public partial interface IRetrieversClient
    {
        /// <summary>
        /// List Retrievers<br/>
        /// List Retrievers for a project.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Retriever>> ListRetrieversApiV1RetrieversGetAsync(
            string? name = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}