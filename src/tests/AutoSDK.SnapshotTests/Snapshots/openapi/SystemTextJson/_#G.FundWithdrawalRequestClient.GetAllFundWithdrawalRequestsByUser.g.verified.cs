//HintName: G.FundWithdrawalRequestClient.GetAllFundWithdrawalRequestsByUser.g.cs

#nullable enable

namespace G
{
    public partial class FundWithdrawalRequestClient
    {
        partial void PrepareGetAllFundWithdrawalRequestsByUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.DateTime? fromDate,
            ref global::System.DateTime? toDate,
            ref long? userId,
            ref int? withdrawalStatusIdEnum,
            ref string? bTCWithdrawalAddress,
            ref int? walletTypeEnumId,
            ref int? pageNumber,
            ref int? pageSize,
            ref string? searchFilterFields,
            ref string? searchFiltersValue,
            ref string? whereFilterFields,
            ref string? whereFilterOperations,
            ref string? whereFilterValues,
            ref string? orderBy,
            ref bool? orderByDesc,
            ref bool? whereFilterAnd,
            ref string? currentCulture);
        partial void PrepareGetAllFundWithdrawalRequestsByUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.DateTime? fromDate,
            global::System.DateTime? toDate,
            long? userId,
            int? withdrawalStatusIdEnum,
            string? bTCWithdrawalAddress,
            int? walletTypeEnumId,
            int? pageNumber,
            int? pageSize,
            string? searchFilterFields,
            string? searchFiltersValue,
            string? whereFilterFields,
            string? whereFilterOperations,
            string? whereFilterValues,
            string? orderBy,
            bool? orderByDesc,
            bool? whereFilterAnd,
            string? currentCulture);
        partial void ProcessGetAllFundWithdrawalRequestsByUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetAllFundWithdrawalRequestsByUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="userId"></param>
        /// <param name="withdrawalStatusIdEnum"></param>
        /// <param name="bTCWithdrawalAddress"></param>
        /// <param name="walletTypeEnumId"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="searchFilterFields"></param>
        /// <param name="searchFiltersValue"></param>
        /// <param name="whereFilterFields"></param>
        /// <param name="whereFilterOperations"></param>
        /// <param name="whereFilterValues"></param>
        /// <param name="orderBy"></param>
        /// <param name="orderByDesc"></param>
        /// <param name="whereFilterAnd"></param>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PaginatedResponseDtoOfFundWithdrawalRequestForListResponseDto> GetAllFundWithdrawalRequestsByUserAsync(
            global::System.DateTime? fromDate = default,
            global::System.DateTime? toDate = default,
            long? userId = default,
            int? withdrawalStatusIdEnum = default,
            string? bTCWithdrawalAddress = default,
            int? walletTypeEnumId = default,
            int? pageNumber = default,
            int? pageSize = default,
            string? searchFilterFields = default,
            string? searchFiltersValue = default,
            string? whereFilterFields = default,
            string? whereFilterOperations = default,
            string? whereFilterValues = default,
            string? orderBy = default,
            bool? orderByDesc = default,
            bool? whereFilterAnd = default,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetAllFundWithdrawalRequestsByUserArguments(
                httpClient: HttpClient,
                fromDate: ref fromDate,
                toDate: ref toDate,
                userId: ref userId,
                withdrawalStatusIdEnum: ref withdrawalStatusIdEnum,
                bTCWithdrawalAddress: ref bTCWithdrawalAddress,
                walletTypeEnumId: ref walletTypeEnumId,
                pageNumber: ref pageNumber,
                pageSize: ref pageSize,
                searchFilterFields: ref searchFilterFields,
                searchFiltersValue: ref searchFiltersValue,
                whereFilterFields: ref whereFilterFields,
                whereFilterOperations: ref whereFilterOperations,
                whereFilterValues: ref whereFilterValues,
                orderBy: ref orderBy,
                orderByDesc: ref orderByDesc,
                whereFilterAnd: ref whereFilterAnd,
                currentCulture: ref currentCulture);

            var __pathBuilder = new PathBuilder(
                path: "/api/FundWithdrawalRequest/by-user",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("FromDate", fromDate?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("ToDate", toDate?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("UserId", userId?.ToString()) 
                .AddOptionalParameter("WithdrawalStatusIdEnum", withdrawalStatusIdEnum?.ToString()) 
                .AddOptionalParameter("BTCWithdrawalAddress", bTCWithdrawalAddress) 
                .AddOptionalParameter("WalletTypeEnumId", walletTypeEnumId?.ToString()) 
                .AddOptionalParameter("PageNumber", pageNumber?.ToString()) 
                .AddOptionalParameter("PageSize", pageSize?.ToString()) 
                .AddOptionalParameter("SearchFilterFields", searchFilterFields) 
                .AddOptionalParameter("SearchFiltersValue", searchFiltersValue) 
                .AddOptionalParameter("WhereFilterFields", whereFilterFields) 
                .AddOptionalParameter("WhereFilterOperations", whereFilterOperations) 
                .AddOptionalParameter("WhereFilterValues", whereFilterValues) 
                .AddOptionalParameter("OrderBy", orderBy) 
                .AddOptionalParameter("OrderByDesc", orderByDesc?.ToString()) 
                .AddOptionalParameter("WhereFilterAnd", whereFilterAnd?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetAllFundWithdrawalRequestsByUserRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                fromDate: fromDate,
                toDate: toDate,
                userId: userId,
                withdrawalStatusIdEnum: withdrawalStatusIdEnum,
                bTCWithdrawalAddress: bTCWithdrawalAddress,
                walletTypeEnumId: walletTypeEnumId,
                pageNumber: pageNumber,
                pageSize: pageSize,
                searchFilterFields: searchFilterFields,
                searchFiltersValue: searchFiltersValue,
                whereFilterFields: whereFilterFields,
                whereFilterOperations: whereFilterOperations,
                whereFilterValues: whereFilterValues,
                orderBy: orderBy,
                orderByDesc: orderByDesc,
                whereFilterAnd: whereFilterAnd,
                currentCulture: currentCulture);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetAllFundWithdrawalRequestsByUserResponse(
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
            // Unauthorized
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::G.ProblemDetails? __value_401 = null;
                if (ReadResponseAsString)
                {
                    __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = global::G.ProblemDetails.FromJson(__content_401, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_401 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = await global::G.ProblemDetails.FromJsonStreamAsync(__contentStream_401, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.ProblemDetails>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
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
            // Forbidden
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::G.ProblemDetails? __value_403 = null;
                if (ReadResponseAsString)
                {
                    __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_403 = global::G.ProblemDetails.FromJson(__content_403, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_403 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_403 = await global::G.ProblemDetails.FromJsonStreamAsync(__contentStream_403, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.ProblemDetails>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
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
                ProcessGetAllFundWithdrawalRequestsByUserResponseContent(
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
                    global::G.PaginatedResponseDtoOfFundWithdrawalRequestForListResponseDto.FromJson(__content, JsonSerializerOptions) ??
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

                using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                return
                    await global::G.PaginatedResponseDtoOfFundWithdrawalRequestForListResponseDto.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}