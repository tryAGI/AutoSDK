//HintName: G.IGenerationApiClient.GetApplicationsByApplicationId.g.cs
#nullable enable

namespace G
{
    public partial interface IGenerationApiClient
    {
        /// <summary>
        /// Application details<br/>
        /// Retrieves detailed information for a specific no-code agent (formerly called no-code applications), including its configuration and current status.
        /// </summary>
        /// <param name="applicationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET https://api.writer.com/v1/applications/{application_id} \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.ApplicationWithInputs> GetApplicationsByApplicationIdAsync(
            string applicationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}