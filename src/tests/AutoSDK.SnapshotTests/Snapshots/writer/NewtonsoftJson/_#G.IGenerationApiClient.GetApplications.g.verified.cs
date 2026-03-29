//HintName: G.IGenerationApiClient.GetApplications.g.cs
#nullable enable

namespace G
{
    public partial interface IGenerationApiClient
    {
        /// <summary>
        /// List applications<br/>
        /// Retrieves a paginated list of no-code agents (formerly called no-code applications) with optional filtering and sorting capabilities.
        /// </summary>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="type">
        /// The type of no-code application.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET https://api.writer.com/v1/applications \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.GetApplicationsResponse> GetApplicationsAsync(
            global::G.GetApplicationsOrder? order = default,
            global::System.Guid? before = default,
            global::System.Guid? after = default,
            int? limit = default,
            global::G.ApplicationType? type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}