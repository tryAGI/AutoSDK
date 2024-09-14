//HintName: G.Api.ListDeployments.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareListDeploymentsArguments(
            global::System.Net.Http.HttpClient httpClient);
        partial void PrepareListDeploymentsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage);
        partial void ProcessListDeploymentsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListDeploymentsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List deployments<br/>
        /// Get a list of deployments associated with the current account, including the latest release configuration for each deployment.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -H "Authorization: Bearer &lt;paste-your-token-here&gt;" \<br/>
        ///   https://api.replicate.com/v1/deployments<br/>
        /// ```<br/>
        /// The response will be a paginated JSON array of deployment objects, sorted with the most recent deployment first:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "next": "http://api.replicate.com/v1/deployments?cursor=cD0yMDIzLTA2LTA2KzIzJTNBNDAlM0EwOC45NjMwMDAlMkIwMCUzQTAw",<br/>
        ///   "previous": null,<br/>
        ///   "results": [<br/>
        ///     {<br/>
        ///       "owner": "replicate",<br/>
        ///       "name": "my-app-image-generator",<br/>
        ///       "current_release": {<br/>
        ///         "number": 1,<br/>
        ///         "model": "stability-ai/sdxl",<br/>
        ///         "version": "da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf",<br/>
        ///         "created_at": "2024-02-15T16:32:57.018467Z",<br/>
        ///         "created_by": {<br/>
        ///           "type": "organization",<br/>
        ///           "username": "acme",<br/>
        ///           "name": "Acme Corp, Inc.",<br/>
        ///           "github_url": "https://github.com/acme",<br/>
        ///         },<br/>
        ///         "configuration": {<br/>
        ///           "hardware": "gpu-t4",<br/>
        ///           "min_instances": 1,<br/>
        ///           "max_instances": 5<br/>
        ///         }<br/>
        ///       }<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DeploymentsListResponse> ListDeploymentsAsync(
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListDeploymentsArguments(
                httpClient: _httpClient);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/deployments", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListDeploymentsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListDeploymentsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListDeploymentsResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.DeploymentsListResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}