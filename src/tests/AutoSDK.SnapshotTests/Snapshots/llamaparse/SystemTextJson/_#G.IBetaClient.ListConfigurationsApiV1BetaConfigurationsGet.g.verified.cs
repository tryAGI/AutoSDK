//HintName: G.IBetaClient.ListConfigurationsApiV1BetaConfigurationsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// List Configurations<br/>
        /// List product configurations for the current project.
        /// </summary>
        /// <param name="productType">
        /// Filter by one or more product types. Repeat the parameter for multiple values.
        /// </param>
        /// <param name="name">
        /// Filter by configuration name.
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page.
        /// </param>
        /// <param name="pageToken">
        /// Pagination token.
        /// </param>
        /// <param name="latestOnly">
        /// Return only the latest version per configuration name.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ConfigurationQueryResponse> ListConfigurationsApiV1BetaConfigurationsGetAsync(
            global::System.Collections.Generic.IList<global::G.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item>? productType = default,
            string? name = default,
            int? pageSize = default,
            string? pageToken = default,
            bool? latestOnly = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}