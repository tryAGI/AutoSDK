//HintName: G.XGatewayClient.XGatewayTransactionsCallback.g.cs

#nullable enable

namespace G
{
    public partial class XGatewayClient
    {
        partial void PrepareXGatewayTransactionsCallbackArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? currentCulture,
            global::G.XGatewayTransactionsCallbackRequest request);
        partial void PrepareXGatewayTransactionsCallbackRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? currentCulture,
            global::G.XGatewayTransactionsCallbackRequest request);
        partial void ProcessXGatewayTransactionsCallbackResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task XGatewayTransactionsCallbackAsync(
            global::G.XGatewayTransactionsCallbackRequest request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareXGatewayTransactionsCallbackArguments(
                httpClient: HttpClient,
                currentCulture: ref currentCulture,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/api/XGateway/callbacks/transactions",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

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

            if (currentCulture != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Current-Culture", currentCulture.ToString());
            }

            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareXGatewayTransactionsCallbackRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                currentCulture: currentCulture,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessXGatewayTransactionsCallbackResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad Request
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::G.ValidationProblemDetails? __value_400 = null;
                if (ReadResponseAsString)
                {
                    __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = global::G.ValidationProblemDetails.FromJson(__content_400, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = await global::G.ValidationProblemDetails.FromJsonStreamAsync(__contentStream_400, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.ValidationProblemDetails>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Not Found
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::G.ProblemDetails? __value_404 = null;
                if (ReadResponseAsString)
                {
                    __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = global::G.ProblemDetails.FromJson(__content_404, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_404 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = await global::G.ProblemDetails.FromJsonStreamAsync(__contentStream_404, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.ProblemDetails>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Internal Server Error
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::G.ProblemDetails? __value_500 = null;
                if (ReadResponseAsString)
                {
                    __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_500 = global::G.ProblemDetails.FromJson(__content_500, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_500 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_500 = await global::G.ProblemDetails.FromJsonStreamAsync(__contentStream_500, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.ProblemDetails>(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
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

                using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

            }
        }

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="callbackType"></param>
        /// <param name="amount"></param>
        /// <param name="currency"></param>
        /// <param name="customerId"></param>
        /// <param name="hash"></param>
        /// <param name="id"></param>
        /// <param name="network"></param>
        /// <param name="status"></param>
        /// <param name="transactionHash"></param>
        /// <param name="type"></param>
        /// <param name="info"></param>
        /// <param name="fees"></param>
        /// <param name="eur"></param>
        /// <param name="usd"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task XGatewayTransactionsCallbackAsync(
            string? callbackType,
            string amount,
            string currency,
            string customerId,
            string? hash,
            string id,
            string? network,
            string? status,
            string? transactionHash,
            string? type,
            global::G.TransactionInfo? info,
            global::G.FeesInfo? fees,
            string? eur,
            string? usd,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.XGatewayTransactionsCallbackRequest
            {
                CallbackType = callbackType,
                Amount = amount,
                Currency = currency,
                CustomerId = customerId,
                Hash = hash,
                Id = id,
                Network = network,
                Status = status,
                TransactionHash = transactionHash,
                Type = type,
                Info = info,
                Fees = fees,
                Eur = eur,
                Usd = usd,
            };

            await XGatewayTransactionsCallbackAsync(
                currentCulture: currentCulture,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}