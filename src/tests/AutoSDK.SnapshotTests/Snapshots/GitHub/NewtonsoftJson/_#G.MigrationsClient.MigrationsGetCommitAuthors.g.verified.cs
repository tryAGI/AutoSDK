﻿//HintName: G.MigrationsClient.MigrationsGetCommitAuthors.g.cs

#nullable enable

namespace G
{
    public partial class MigrationsClient
    {
        partial void PrepareMigrationsGetCommitAuthorsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int? since);
        partial void PrepareMigrationsGetCommitAuthorsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int? since);
        partial void ProcessMigrationsGetCommitAuthorsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMigrationsGetCommitAuthorsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get commit authors<br/>
        /// Each type of source control system represents authors in a different way. For example, a Git commit author has a display name and an email address, but a Subversion commit author just has a username. The GitHub Importer will make the author information valid, but the author might not be correct. For example, it will change the bare Subversion username `hubot` into something like `hubot &lt;hubot@12341234-abab-fefe-8787-fedcba987654&gt;`.<br/>
        /// This endpoint and the [Map a commit author](https://docs.github.com/rest/migrations/source-imports#map-a-commit-author) endpoint allow you to provide correct Git author information.<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** Due to very low levels of usage and available alternatives, this endpoint is deprecated and will no longer be available from 00:00 UTC on April 12, 2024. For more details and alternatives, see the [changelog](https://gh.io/source-imports-api-deprecation).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="since"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PorterAuthor>> MigrationsGetCommitAuthorsAsync(
            string owner,
            string repo,
            int? since = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareMigrationsGetCommitAuthorsArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                since: ref since);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/import/authors",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("since", since?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareMigrationsGetCommitAuthorsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                since: since);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessMigrationsGetCommitAuthorsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessMigrationsGetCommitAuthorsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.PorterAuthor>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}