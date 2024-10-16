//HintName: G.VoicesClient.GetSharedVoices.g.cs

#nullable enable

namespace G
{
    public partial class VoicesClient
    {
        partial void PrepareGetSharedVoicesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? pageSize,
            ref string? category,
            ref string? gender,
            ref string? age,
            ref string? accent,
            ref string? language,
            ref string? search,
            global::System.Collections.Generic.IList<string>? useCases,
            global::System.Collections.Generic.IList<string>? descriptives,
            ref bool? featured,
            ref bool? readerAppEnabled,
            ref string? ownerId,
            ref string? sort,
            ref int? page,
            ref string? xiApiKey);
        partial void PrepareGetSharedVoicesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? pageSize,
            string? category,
            string? gender,
            string? age,
            string? accent,
            string? language,
            string? search,
            global::System.Collections.Generic.IList<string>? useCases,
            global::System.Collections.Generic.IList<string>? descriptives,
            bool? featured,
            bool? readerAppEnabled,
            string? ownerId,
            string? sort,
            int? page,
            string? xiApiKey);
        partial void ProcessGetSharedVoicesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetSharedVoicesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Voices<br/>
        /// Gets a list of shared voices.
        /// </summary>
        /// <param name="pageSize">
        /// How many shared voices to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="category">
        /// voice category used for filtering
        /// </param>
        /// <param name="gender">
        /// gender used for filtering
        /// </param>
        /// <param name="age">
        /// age used for filtering
        /// </param>
        /// <param name="accent">
        /// accent used for filtering
        /// </param>
        /// <param name="language">
        /// language used for filtering
        /// </param>
        /// <param name="search">
        /// search term used for filtering
        /// </param>
        /// <param name="useCases">
        /// use-case used for filtering
        /// </param>
        /// <param name="descriptives">
        /// search term used for filtering
        /// </param>
        /// <param name="featured">
        /// Filter featured voices<br/>
        /// Default Value: false
        /// </param>
        /// <param name="readerAppEnabled">
        /// Filter voices that are enabled for the reader app<br/>
        /// Default Value: false
        /// </param>
        /// <param name="ownerId">
        /// Filter voices by public owner ID
        /// </param>
        /// <param name="sort">
        /// sort criteria
        /// </param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetLibraryVoicesResponseModel> GetSharedVoicesAsync(
            int? pageSize = 30,
            string? category = default,
            string? gender = default,
            string? age = default,
            string? accent = default,
            string? language = default,
            string? search = default,
            global::System.Collections.Generic.IList<string>? useCases = default,
            global::System.Collections.Generic.IList<string>? descriptives = default,
            bool? featured = false,
            bool? readerAppEnabled = false,
            string? ownerId = default,
            string? sort = default,
            int? page = 0,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetSharedVoicesArguments(
                httpClient: _httpClient,
                pageSize: ref pageSize,
                category: ref category,
                gender: ref gender,
                age: ref age,
                accent: ref accent,
                language: ref language,
                search: ref search,
                useCases: useCases,
                descriptives: descriptives,
                featured: ref featured,
                readerAppEnabled: ref readerAppEnabled,
                ownerId: ref ownerId,
                sort: ref sort,
                page: ref page,
                xiApiKey: ref xiApiKey);

            var __pathBuilder = new PathBuilder(
                path: "/v1/shared-voices",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("page_size", pageSize?.ToString()) 
                .AddOptionalParameter("category", category) 
                .AddOptionalParameter("gender", gender) 
                .AddOptionalParameter("age", age) 
                .AddOptionalParameter("accent", accent) 
                .AddOptionalParameter("language", language) 
                .AddOptionalParameter("search", search) 
                .AddOptionalParameter("use_cases", useCases, delimiter: ",", explode: true) 
                .AddOptionalParameter("descriptives", descriptives, delimiter: ",", explode: true) 
                .AddOptionalParameter("featured", featured?.ToString()) 
                .AddOptionalParameter("reader_app_enabled", readerAppEnabled?.ToString()) 
                .AddOptionalParameter("owner_id", ownerId) 
                .AddOptionalParameter("sort", sort) 
                .AddOptionalParameter("page", page?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (xiApiKey != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }


            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetSharedVoicesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                pageSize: pageSize,
                category: category,
                gender: gender,
                age: age,
                accent: accent,
                language: language,
                search: search,
                useCases: useCases,
                descriptives: descriptives,
                featured: featured,
                readerAppEnabled: readerAppEnabled,
                ownerId: ownerId,
                sort: sort,
                page: page,
                xiApiKey: xiApiKey);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetSharedVoicesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetSharedVoicesResponseContent(
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
                global::G.GetLibraryVoicesResponseModel.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}