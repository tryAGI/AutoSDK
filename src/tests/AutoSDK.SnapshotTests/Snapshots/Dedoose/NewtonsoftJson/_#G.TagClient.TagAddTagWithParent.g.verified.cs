//HintName: G.TagClient.TagAddTagWithParent.g.cs

#nullable enable

namespace G
{
    public partial class TagClient
    {
        partial void PrepareTagAddTagWithParentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? proejctId,
            ref global::System.Guid? parentTagId,
            ref string? title,
            ref string? description,
            ref bool? isWeighted,
            ref double? weightMin,
            ref double? weightMax,
            ref double? weightDefault,
            ref bool? allowDecimalWeights,
            ref double? color);
        partial void PrepareTagAddTagWithParentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? proejctId,
            global::System.Guid? parentTagId,
            string? title,
            string? description,
            bool? isWeighted,
            double? weightMin,
            double? weightMax,
            double? weightDefault,
            bool? allowDecimalWeights,
            double? color);
        partial void ProcessTagAddTagWithParentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTagAddTagWithParentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// AddTagWithParent.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="proejctId"></param>
        /// <param name="parentTagId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="isWeighted"></param>
        /// <param name="weightMin"></param>
        /// <param name="weightMax"></param>
        /// <param name="weightDefault"></param>
        /// <param name="allowDecimalWeights"></param>
        /// <param name="color"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Tag> TagAddTagWithParentAsync(
            string? token = default,
            global::System.Guid? proejctId = default,
            global::System.Guid? parentTagId = default,
            string? title = default,
            string? description = default,
            bool? isWeighted = default,
            double? weightMin = default,
            double? weightMax = default,
            double? weightDefault = default,
            bool? allowDecimalWeights = default,
            double? color = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareTagAddTagWithParentArguments(
                httpClient: _httpClient,
                token: ref token,
                proejctId: ref proejctId,
                parentTagId: ref parentTagId,
                title: ref title,
                description: ref description,
                isWeighted: ref isWeighted,
                weightMin: ref weightMin,
                weightMax: ref weightMax,
                weightDefault: ref weightDefault,
                allowDecimalWeights: ref allowDecimalWeights,
                color: ref color);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/tag/addtagwithparent",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("proejctId", proejctId?.ToString()) 
                .AddOptionalParameter("parentTagId", parentTagId?.ToString()) 
                .AddOptionalParameter("title", title) 
                .AddOptionalParameter("description", description) 
                .AddOptionalParameter("isWeighted", isWeighted?.ToString()) 
                .AddOptionalParameter("weightMin", weightMin?.ToString()) 
                .AddOptionalParameter("weightMax", weightMax?.ToString()) 
                .AddOptionalParameter("weightDefault", weightDefault?.ToString()) 
                .AddOptionalParameter("allowDecimalWeights", allowDecimalWeights?.ToString()) 
                .AddOptionalParameter("color", color?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }


            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareTagAddTagWithParentRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                proejctId: proejctId,
                parentTagId: parentTagId,
                title: title,
                description: description,
                isWeighted: isWeighted,
                weightMin: weightMin,
                weightMax: weightMax,
                weightDefault: weightDefault,
                allowDecimalWeights: allowDecimalWeights,
                color: color);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessTagAddTagWithParentResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessTagAddTagWithParentResponseContent(
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
                global::G.Tag.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}