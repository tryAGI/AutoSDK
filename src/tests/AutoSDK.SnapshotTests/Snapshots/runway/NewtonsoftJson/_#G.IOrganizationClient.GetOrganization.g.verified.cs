//HintName: G.IOrganizationClient.GetOrganization.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizationClient
    {
        /// <summary>
        /// Get organization information<br/>
        /// Get usage tier and credit balance information about the organization associated with the API key used to make the request.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// // npm install --save @runwayml/sdk<br/>
        /// import RunwayML from '@runwayml/sdk';<br/>
        /// // The env var RUNWAYML_API_SECRET is expected to contain your API key.<br/>
        /// const client = new RunwayML();<br/>
        /// const details = await client.organization.retrieve();<br/>
        /// console.log(details.creditBalance);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.Response23> GetOrganizationAsync(
            string xRunwayVersion = "2024-11-06",
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}