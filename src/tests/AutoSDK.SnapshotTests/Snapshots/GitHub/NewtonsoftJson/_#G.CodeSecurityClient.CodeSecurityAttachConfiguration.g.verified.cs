//HintName: G.CodeSecurityClient.CodeSecurityAttachConfiguration.g.cs

#nullable enable

namespace G
{
    public partial class CodeSecurityClient
    {
        partial void PrepareCodeSecurityAttachConfigurationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int configurationId,
            global::G.CodeSecurityAttachConfigurationRequest request);
        partial void PrepareCodeSecurityAttachConfigurationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int configurationId,
            global::G.CodeSecurityAttachConfigurationRequest request);
        partial void ProcessCodeSecurityAttachConfigurationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCodeSecurityAttachConfigurationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Attach a configuration to repositories<br/>
        /// Attach a code security configuration to a set of repositories. If the repositories specified are already attached to a configuration, they will be re-attached to the provided configuration.<br/>
        /// If insufficient GHAS licenses are available to attach the configuration to a repository, only free features will be enabled.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="configurationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> CodeSecurityAttachConfigurationAsync(
            string org,
            int configurationId,
            global::G.CodeSecurityAttachConfigurationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCodeSecurityAttachConfigurationArguments(
                httpClient: HttpClient,
                org: ref org,
                configurationId: ref configurationId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/code-security/configurations/{configurationId}/attach",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            PrepareCodeSecurityAttachConfigurationRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                configurationId: configurationId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCodeSecurityAttachConfigurationResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCodeSecurityAttachConfigurationResponseContent(
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

                    return __content;
            }
            else
            {
                __response.EnsureSuccessStatusCode();
                using var __responseStream = await __response.Content.ReadAsStreamAsync().ConfigureAwait(false);

                var __responseValue = global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<string?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__responseStream)));

                return
                    __responseValue ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Attach a configuration to repositories<br/>
        /// Attach a code security configuration to a set of repositories. If the repositories specified are already attached to a configuration, they will be re-attached to the provided configuration.<br/>
        /// If insufficient GHAS licenses are available to attach the configuration to a repository, only free features will be enabled.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="configurationId"></param>
        /// <param name="scope">
        /// The type of repositories to attach the configuration to. `selected` means the configuration will be attached to only the repositories specified by `selected_repository_ids`
        /// </param>
        /// <param name="selectedRepositoryIds">
        /// An array of repository IDs to attach the configuration to. You can only provide a list of repository ids when the `scope` is set to `selected`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> CodeSecurityAttachConfigurationAsync(
            string org,
            int configurationId,
            global::G.CodeSecurityAttachConfigurationRequestScope scope,
            global::System.Collections.Generic.IList<int>? selectedRepositoryIds = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CodeSecurityAttachConfigurationRequest
            {
                Scope = scope,
                SelectedRepositoryIds = selectedRepositoryIds,
            };

            return await CodeSecurityAttachConfigurationAsync(
                org: org,
                configurationId: configurationId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}