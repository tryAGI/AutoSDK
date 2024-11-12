//HintName: G.IScalingConfigurationsClient.GetPipelineList.g.cs
#nullable enable

namespace G
{
    public partial interface IScalingConfigurationsClient
    {
        /// <summary>
        /// Get Pipeline List<br/>
        /// Get a list of pipelines scoped to the user which use a scaling configuration
        /// </summary>
        /// <param name="name"></param>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="orderBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedGetLean> GetPipelineListAsync(
            string name,
            int? skip = default,
            int? limit = default,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}