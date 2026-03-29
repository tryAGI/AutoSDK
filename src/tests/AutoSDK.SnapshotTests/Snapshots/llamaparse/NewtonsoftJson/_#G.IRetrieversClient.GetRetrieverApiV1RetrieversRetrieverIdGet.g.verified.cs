//HintName: G.IRetrieversClient.GetRetrieverApiV1RetrieversRetrieverIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IRetrieversClient
    {
        /// <summary>
        /// Get Retriever<br/>
        /// Get a Retriever by ID.
        /// </summary>
        /// <param name="retrieverId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Retriever> GetRetrieverApiV1RetrieversRetrieverIdGetAsync(
            global::System.Guid retrieverId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}