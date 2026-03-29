//HintName: G.ILlamaExtractClient.GetExtractionAgentByNameApiV1ExtractionExtractionAgentsByNameNameGet.g.cs
#nullable enable

namespace G
{
    public partial interface ILlamaExtractClient
    {
        /// <summary>
        /// Get Extraction Agent By Name
        /// </summary>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.ExtractAgent> GetExtractionAgentByNameApiV1ExtractionExtractionAgentsByNameNameGetAsync(
            string name,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}