//HintName: G.MigrationsClient.MigrationsCancelImport.g.cs

#nullable enable

namespace G
{
    public partial class MigrationsClient
    {
        partial void PrepareMigrationsCancelImportArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo);
        partial void PrepareMigrationsCancelImportRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo);
        partial void ProcessMigrationsCancelImportResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Cancel an import<br/>
        /// Stop an import for a repository.<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** Due to very low levels of usage and available alternatives, this endpoint is deprecated and will no longer be available from 00:00 UTC on April 12, 2024. For more details and alternatives, see the [changelog](https://gh.io/source-imports-api-deprecation).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task MigrationsCancelImportAsync(
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareMigrationsCancelImportArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/import",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareMigrationsCancelImportRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessMigrationsCancelImportResponse(
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
    }
}