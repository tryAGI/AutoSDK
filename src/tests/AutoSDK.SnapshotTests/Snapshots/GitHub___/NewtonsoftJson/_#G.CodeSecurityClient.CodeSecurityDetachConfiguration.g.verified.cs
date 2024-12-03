//HintName: G.CodeSecurityClient.CodeSecurityDetachConfiguration.g.cs

#nullable enable

namespace G
{
    public partial class CodeSecurityClient
    {
        partial void PrepareCodeSecurityDetachConfigurationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            global::G.CodeSecurityDetachConfigurationRequest request);
        partial void PrepareCodeSecurityDetachConfigurationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::G.CodeSecurityDetachConfigurationRequest request);
        partial void ProcessCodeSecurityDetachConfigurationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Detach configurations from repositories<br/>
        /// Detach code security configuration(s) from a set of repositories.<br/>
        /// Repositories will retain their settings but will no longer be associated with the configuration.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task CodeSecurityDetachConfigurationAsync(
            string org,
            global::G.CodeSecurityDetachConfigurationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCodeSecurityDetachConfigurationArguments(
                httpClient: HttpClient,
                org: ref org,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/code-security/configurations/detach",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCodeSecurityDetachConfigurationRequest(
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
            ProcessCodeSecurityDetachConfigurationResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::G.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    innerException: __ex,
                    statusCode: __response.StatusCode)
                {
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
        }

        /// <summary>
        /// Detach configurations from repositories<br/>
        /// Detach code security configuration(s) from a set of repositories.<br/>
        /// Repositories will retain their settings but will no longer be associated with the configuration.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="selectedRepositoryIds">
        /// An array of repository IDs to detach from configurations.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CodeSecurityDetachConfigurationAsync(
            string org,
            global::System.Collections.Generic.IList<int>? selectedRepositoryIds = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CodeSecurityDetachConfigurationRequest
            {
                SelectedRepositoryIds = selectedRepositoryIds,
            };

            await CodeSecurityDetachConfigurationAsync(
                org: org,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}