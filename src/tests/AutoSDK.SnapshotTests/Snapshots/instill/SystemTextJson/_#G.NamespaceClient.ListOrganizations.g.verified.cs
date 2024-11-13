//HintName: G.NamespaceClient.ListOrganizations.g.cs

#nullable enable

namespace G
{
    public partial class NamespaceClient
    {
        partial void PrepareListOrganizationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? pageSize,
            ref string? pageToken,
            ref global::G.ListOrganizationsView? view,
            ref string? filter);
        partial void PrepareListOrganizationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? pageSize,
            string? pageToken,
            global::G.ListOrganizationsView? view,
            string? filter);
        partial void ProcessListOrganizationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListOrganizationsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List organizations<br/>
        /// Returns a paginated list of organizations.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="view"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListOrganizationsResponse> ListOrganizationsAsync(
            int? pageSize = default,
            string? pageToken = default,
            global::G.ListOrganizationsView? view = default,
            string? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListOrganizationsArguments(
                httpClient: HttpClient,
                pageSize: ref pageSize,
                pageToken: ref pageToken,
                view: ref view,
                filter: ref filter);

            var __pathBuilder = new PathBuilder(
                path: "/v1beta/organizations",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("pageSize", pageSize?.ToString()) 
                .AddOptionalParameter("pageToken", pageToken) 
                .AddOptionalParameter("view", view?.ToValueString()) 
                .AddOptionalParameter("filter", filter) 
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
            PrepareListOrganizationsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                pageSize: pageSize,
                pageToken: pageToken,
                view: view,
                filter: filter);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListOrganizationsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Returned when the client credentials are not valid.
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                string? __value_401 = null;
                if (ReadResponseAsString)
                {
                    __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content_401, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_401 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = await global::System.Text.Json.JsonSerializer.DeserializeAsync<string?>(__contentStream_401, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<string>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // An unexpected error response.
            if (!__response.IsSuccessStatusCode)
            {
                string? __content_default = null;
                global::G.RpcStatus? __value_default = null;
                if (ReadResponseAsString)
                {
                    __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_default = global::G.RpcStatus.FromJson(__content_default, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_default = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_default = await global::G.RpcStatus.FromJsonStreamAsync(__contentStream_default, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.RpcStatus>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_default,
                    ResponseObject = __value_default,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessListOrganizationsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                return
                    global::G.ListOrganizationsResponse.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
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

                using var __content = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                return
                    await global::G.ListOrganizationsResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}