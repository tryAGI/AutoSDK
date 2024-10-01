//HintName: G.Api.DeleteDeployments.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareDeleteDeploymentsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string deploymentOwner,
            ref string deploymentName);
        partial void PrepareDeleteDeploymentsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string deploymentOwner,
            string deploymentName);
        partial void ProcessDeleteDeploymentsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Delete a deployment<br/>
        /// Delete a deployment<br/>
        /// Deployment deletion has some restrictions:<br/>
        /// - You can only delete deployments that have been offline and unused for at least 15 minutes.<br/>
        /// Example cURL request:<br/>
        /// ```command<br/>
        /// curl -s -X DELETE \<br/>
        ///   -H "Authorization: Bearer &lt;paste-your-token-here&gt;" \<br/>
        ///   https://api.replicate.com/v1/deployments/acme/my-app-image-generator<br/>
        /// ```<br/>
        /// The response will be an empty 204, indicating the deployment has been deleted.
        /// </summary>
        /// <param name="deploymentOwner"></param>
        /// <param name="deploymentName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task DeleteDeploymentsAsync(
            string deploymentOwner,
            string deploymentName,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDeleteDeploymentsArguments(
                httpClient: _httpClient,
                deploymentOwner: ref deploymentOwner,
                deploymentName: ref deploymentName);

            var __pathBuilder = new PathBuilder(
                path: $"/deployments/{deploymentOwner}/{deploymentName}",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeleteDeploymentsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                deploymentOwner: deploymentOwner,
                deploymentName: deploymentName);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDeleteDeploymentsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }
    }
}