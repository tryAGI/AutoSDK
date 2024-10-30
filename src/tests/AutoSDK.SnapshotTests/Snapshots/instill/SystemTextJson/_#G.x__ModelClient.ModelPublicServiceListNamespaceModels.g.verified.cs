//HintName: G.x__ModelClient.ModelPublicServiceListNamespaceModels.g.cs

#nullable enable

namespace G
{
    public partial class x__ModelClient
    {
        partial void PrepareModelPublicServiceListNamespaceModelsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string namespaceId,
            ref int? pageSize,
            ref string? pageToken,
            ref global::G.ModelPublicServiceListNamespaceModelsView? view,
            ref bool? showDeleted,
            ref string? filter,
            ref global::G.ModelPublicServiceListNamespaceModelsVisibility? visibility,
            ref string? orderBy);
        partial void PrepareModelPublicServiceListNamespaceModelsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string namespaceId,
            int? pageSize,
            string? pageToken,
            global::G.ModelPublicServiceListNamespaceModelsView? view,
            bool? showDeleted,
            string? filter,
            global::G.ModelPublicServiceListNamespaceModelsVisibility? visibility,
            string? orderBy);
        partial void ProcessModelPublicServiceListNamespaceModelsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessModelPublicServiceListNamespaceModelsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List namespace models<br/>
        /// Returns a paginated list of models.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="view"></param>
        /// <param name="showDeleted"></param>
        /// <param name="filter"></param>
        /// <param name="visibility"></param>
        /// <param name="orderBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListNamespaceModelsResponse> ModelPublicServiceListNamespaceModelsAsync(
            string namespaceId,
            int? pageSize = default,
            string? pageToken = default,
            global::G.ModelPublicServiceListNamespaceModelsView? view = default,
            bool? showDeleted = default,
            string? filter = default,
            global::G.ModelPublicServiceListNamespaceModelsVisibility? visibility = default,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareModelPublicServiceListNamespaceModelsArguments(
                httpClient: HttpClient,
                namespaceId: ref namespaceId,
                pageSize: ref pageSize,
                pageToken: ref pageToken,
                view: ref view,
                showDeleted: ref showDeleted,
                filter: ref filter,
                visibility: ref visibility,
                orderBy: ref orderBy);

            var __pathBuilder = new PathBuilder(
                path: $"/v1alpha/namespaces/{namespaceId}/models",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("pageSize", pageSize?.ToString()) 
                .AddOptionalParameter("pageToken", pageToken) 
                .AddOptionalParameter("view", view?.ToValueString()) 
                .AddOptionalParameter("showDeleted", showDeleted?.ToString()) 
                .AddOptionalParameter("filter", filter) 
                .AddOptionalParameter("visibility", visibility?.ToValueString()) 
                .AddOptionalParameter("orderBy", orderBy) 
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
            PrepareModelPublicServiceListNamespaceModelsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                namespaceId: namespaceId,
                pageSize: pageSize,
                pageToken: pageToken,
                view: view,
                showDeleted: showDeleted,
                filter: filter,
                visibility: visibility,
                orderBy: orderBy);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessModelPublicServiceListNamespaceModelsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessModelPublicServiceListNamespaceModelsResponseContent(
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
                global::G.ListNamespaceModelsResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}