//HintName: G.CodeSecurityClient.CodeSecurityDeleteConfiguration.g.cs

#nullable enable

namespace G
{
    public partial class CodeSecurityClient
    {
        partial void PrepareCodeSecurityDeleteConfigurationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int configurationId);
        partial void PrepareCodeSecurityDeleteConfigurationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int configurationId);
        partial void ProcessCodeSecurityDeleteConfigurationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Delete a code security configuration<br/>
        /// Deletes the desired code security configuration from an organization.<br/>
        /// Repositories attached to the configuration will retain their settings but will no longer be associated with<br/>
        /// the configuration.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="configurationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CodeSecurityDeleteConfigurationAsync(
            string org,
            int configurationId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCodeSecurityDeleteConfigurationArguments(
                httpClient: HttpClient,
                org: ref org,
                configurationId: ref configurationId);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/code-security/configurations/{configurationId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCodeSecurityDeleteConfigurationRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                configurationId: configurationId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCodeSecurityDeleteConfigurationResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            __response.EnsureSuccessStatusCode();
        }
    }
}