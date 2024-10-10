//HintName: G.WorkspaceClient.GetSsoProviderAdminAdminN8enylacgdSsoProviderGet.g.cs

#nullable enable

namespace G
{
    public partial class WorkspaceClient
    {
        partial void PrepareGetSsoProviderAdminAdminN8enylacgdSsoProviderGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string workspaceId);
        partial void PrepareGetSsoProviderAdminAdminN8enylacgdSsoProviderGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string workspaceId);
        partial void ProcessGetSsoProviderAdminAdminN8enylacgdSsoProviderGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetSsoProviderAdminAdminN8enylacgdSsoProviderGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Sso Provider Admin
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SsoProviderResponseModel> GetSsoProviderAdminAdminN8enylacgdSsoProviderGetAsync(
            string workspaceId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetSsoProviderAdminAdminN8enylacgdSsoProviderGetArguments(
                httpClient: _httpClient,
                workspaceId: ref workspaceId);

            var __pathBuilder = new PathBuilder(
                path: "/admin/n8enylacgd/sso-provider",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("workspace_id", workspaceId) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetSsoProviderAdminAdminN8enylacgdSsoProviderGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                workspaceId: workspaceId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetSsoProviderAdminAdminN8enylacgdSsoProviderGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetSsoProviderAdminAdminN8enylacgdSsoProviderGetResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.SsoProviderResponseModel?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}