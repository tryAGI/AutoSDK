//HintName: G.ModelClient.ModelPublicServiceListModelRunsByRequester.g.cs

#nullable enable

namespace G
{
    public partial class ModelClient
    {
        partial void PrepareModelPublicServiceListModelRunsByRequesterArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? pageSize,
            ref int? page,
            ref string? orderBy,
            ref string? filter,
            ref global::System.DateTime? start,
            ref global::System.DateTime? stop,
            ref string requesterId,
            ref string? instillRequesterUid);
        partial void PrepareModelPublicServiceListModelRunsByRequesterRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? pageSize,
            int? page,
            string? orderBy,
            string? filter,
            global::System.DateTime? start,
            global::System.DateTime? stop,
            string requesterId,
            string? instillRequesterUid);
        partial void ProcessModelPublicServiceListModelRunsByRequesterResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessModelPublicServiceListModelRunsByRequesterResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Model Runs of a Namespace (user or organization)<br/>
        /// Returns a paginated list of runs for 1 or more models. This is mainly used by dashboard.<br/>
        /// The requester can view all the runs by the requester across different models.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="page"></param>
        /// <param name="orderBy"></param>
        /// <param name="filter"></param>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        /// <param name="requesterId"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListModelRunsByRequesterResponse> ModelPublicServiceListModelRunsByRequesterAsync(
            string requesterId,
            int? pageSize = default,
            int? page = default,
            string? orderBy = default,
            string? filter = default,
            global::System.DateTime? start = default,
            global::System.DateTime? stop = default,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareModelPublicServiceListModelRunsByRequesterArguments(
                httpClient: HttpClient,
                pageSize: ref pageSize,
                page: ref page,
                orderBy: ref orderBy,
                filter: ref filter,
                start: ref start,
                stop: ref stop,
                requesterId: ref requesterId,
                instillRequesterUid: ref instillRequesterUid);

            var __pathBuilder = new PathBuilder(
                path: "/v1alpha/dashboard/models/runs",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("pageSize", pageSize?.ToString()) 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("orderBy", orderBy) 
                .AddOptionalParameter("filter", filter) 
                .AddOptionalParameter("start", start?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("stop", stop?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddRequiredParameter("requesterId", requesterId) 
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

            if (instillRequesterUid != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Instill-Requester-Uid", instillRequesterUid.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareModelPublicServiceListModelRunsByRequesterRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                pageSize: pageSize,
                page: page,
                orderBy: orderBy,
                filter: filter,
                start: start,
                stop: stop,
                requesterId: requesterId,
                instillRequesterUid: instillRequesterUid);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessModelPublicServiceListModelRunsByRequesterResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessModelPublicServiceListModelRunsByRequesterResponseContent(
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
                    global::G.ListModelRunsByRequesterResponse.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                __response.EnsureSuccessStatusCode();
                using var __responseStream = await __response.Content.ReadAsStreamAsync().ConfigureAwait(false);

                var __responseValue = await global::G.ListModelRunsByRequesterResponse.FromJsonStreamAsync(__responseStream, JsonSerializerOptions).ConfigureAwait(false);

                return
                    __responseValue ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}