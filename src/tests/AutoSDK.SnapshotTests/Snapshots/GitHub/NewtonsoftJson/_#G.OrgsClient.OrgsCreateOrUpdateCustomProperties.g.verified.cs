//HintName: G.OrgsClient.OrgsCreateOrUpdateCustomProperties.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsCreateOrUpdateCustomPropertiesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            global::G.OrgsCreateOrUpdateCustomPropertiesRequest request);
        partial void PrepareOrgsCreateOrUpdateCustomPropertiesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::G.OrgsCreateOrUpdateCustomPropertiesRequest request);
        partial void ProcessOrgsCreateOrUpdateCustomPropertiesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsCreateOrUpdateCustomPropertiesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create or update custom properties for an organization<br/>
        /// Creates new or updates existing custom properties defined for an organization in a batch.<br/>
        /// To use this endpoint, the authenticated user must be one of:<br/>
        ///   - An administrator for the organization.<br/>
        ///   - A user, or a user on a team, with the fine-grained permission of `custom_properties_org_definitions_manager` in the organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.CustomProperty>> OrgsCreateOrUpdateCustomPropertiesAsync(
            string org,
            global::G.OrgsCreateOrUpdateCustomPropertiesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOrgsCreateOrUpdateCustomPropertiesArguments(
                httpClient: HttpClient,
                org: ref org,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/properties/schema",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareOrgsCreateOrUpdateCustomPropertiesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOrgsCreateOrUpdateCustomPropertiesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessOrgsCreateOrUpdateCustomPropertiesResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.CustomProperty>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create or update custom properties for an organization<br/>
        /// Creates new or updates existing custom properties defined for an organization in a batch.<br/>
        /// To use this endpoint, the authenticated user must be one of:<br/>
        ///   - An administrator for the organization.<br/>
        ///   - A user, or a user on a team, with the fine-grained permission of `custom_properties_org_definitions_manager` in the organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="properties">
        /// The array of custom properties to create or update.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.CustomProperty>> OrgsCreateOrUpdateCustomPropertiesAsync(
            string org,
            global::System.Collections.Generic.IList<global::G.CustomProperty> properties,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.OrgsCreateOrUpdateCustomPropertiesRequest
            {
                Properties = properties,
            };

            return await OrgsCreateOrUpdateCustomPropertiesAsync(
                org: org,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}