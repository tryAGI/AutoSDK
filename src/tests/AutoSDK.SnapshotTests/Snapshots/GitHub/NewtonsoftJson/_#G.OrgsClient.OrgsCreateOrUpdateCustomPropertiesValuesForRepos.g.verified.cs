//HintName: G.OrgsClient.OrgsCreateOrUpdateCustomPropertiesValuesForRepos.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsCreateOrUpdateCustomPropertiesValuesForReposArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            global::G.OrgsCreateOrUpdateCustomPropertiesValuesForReposRequest request);
        partial void PrepareOrgsCreateOrUpdateCustomPropertiesValuesForReposRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::G.OrgsCreateOrUpdateCustomPropertiesValuesForReposRequest request);
        partial void ProcessOrgsCreateOrUpdateCustomPropertiesValuesForReposResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsCreateOrUpdateCustomPropertiesValuesForReposResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create or update custom property values for organization repositories<br/>
        /// Create new or update existing custom property values for repositories in a batch that belong to an organization.<br/>
        /// Each target repository will have its custom property values updated to match the values provided in the request.<br/>
        /// A maximum of 30 repositories can be updated in a single request.<br/>
        /// Using a value of `null` for a custom property will remove or 'unset' the property value from the repository.<br/>
        /// To use this endpoint, the authenticated user must be one of:<br/>
        ///   - An administrator for the organization.<br/>
        ///   - A user, or a user on a team, with the fine-grained permission of `custom_properties_org_values_editor` in the organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BasicError> OrgsCreateOrUpdateCustomPropertiesValuesForReposAsync(
            string org,
            global::G.OrgsCreateOrUpdateCustomPropertiesValuesForReposRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareOrgsCreateOrUpdateCustomPropertiesValuesForReposArguments(
                httpClient: _httpClient,
                org: ref org,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/properties/values",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareOrgsCreateOrUpdateCustomPropertiesValuesForReposRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessOrgsCreateOrUpdateCustomPropertiesValuesForReposResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessOrgsCreateOrUpdateCustomPropertiesValuesForReposResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.BasicError?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create or update custom property values for organization repositories<br/>
        /// Create new or update existing custom property values for repositories in a batch that belong to an organization.<br/>
        /// Each target repository will have its custom property values updated to match the values provided in the request.<br/>
        /// A maximum of 30 repositories can be updated in a single request.<br/>
        /// Using a value of `null` for a custom property will remove or 'unset' the property value from the repository.<br/>
        /// To use this endpoint, the authenticated user must be one of:<br/>
        ///   - An administrator for the organization.<br/>
        ///   - A user, or a user on a team, with the fine-grained permission of `custom_properties_org_values_editor` in the organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="repositoryNames">
        /// The names of repositories that the custom property values will be applied to.
        /// </param>
        /// <param name="properties">
        /// List of custom property names and associated values to apply to the repositories.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BasicError> OrgsCreateOrUpdateCustomPropertiesValuesForReposAsync(
            string org,
            global::System.Collections.Generic.IList<string> repositoryNames,
            global::System.Collections.Generic.IList<global::G.CustomPropertyValue> properties,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.OrgsCreateOrUpdateCustomPropertiesValuesForReposRequest
            {
                RepositoryNames = repositoryNames,
                Properties = properties,
            };

            return await OrgsCreateOrUpdateCustomPropertiesValuesForReposAsync(
                org: org,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}