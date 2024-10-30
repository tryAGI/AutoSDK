//HintName: G.x__VDPClient.PipelinePublicServiceListComponentDefinitions.g.cs

#nullable enable

namespace G
{
    public partial class x__VDPClient
    {
        partial void PreparePipelinePublicServiceListComponentDefinitionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? pageSize,
            ref global::G.PipelinePublicServiceListComponentDefinitionsView? view,
            ref string? filter,
            ref int? page);
        partial void PreparePipelinePublicServiceListComponentDefinitionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? pageSize,
            global::G.PipelinePublicServiceListComponentDefinitionsView? view,
            string? filter,
            int? page);
        partial void ProcessPipelinePublicServiceListComponentDefinitionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPipelinePublicServiceListComponentDefinitionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List component definitions<br/>
        /// Returns a paginated list of component definitions, regardless their type.<br/>
        /// This offers a single source of truth, with pagination and filter<br/>
        /// capabilities, for the components that might be used in a VDP pipeline.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="view"></param>
        /// <param name="filter"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListComponentDefinitionsResponse> PipelinePublicServiceListComponentDefinitionsAsync(
            int? pageSize = default,
            global::G.PipelinePublicServiceListComponentDefinitionsView? view = default,
            string? filter = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PreparePipelinePublicServiceListComponentDefinitionsArguments(
                httpClient: HttpClient,
                pageSize: ref pageSize,
                view: ref view,
                filter: ref filter,
                page: ref page);

            var __pathBuilder = new PathBuilder(
                path: "/v1beta/component-definitions",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("pageSize", pageSize?.ToString()) 
                .AddOptionalParameter("view", view?.ToValueString()) 
                .AddOptionalParameter("filter", filter) 
                .AddOptionalParameter("page", page?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePipelinePublicServiceListComponentDefinitionsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                pageSize: pageSize,
                view: view,
                filter: filter,
                page: page);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPipelinePublicServiceListComponentDefinitionsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessPipelinePublicServiceListComponentDefinitionsResponseContent(
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
                global::G.ListComponentDefinitionsResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}