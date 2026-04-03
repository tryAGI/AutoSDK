//HintName: G.DatasetsClient.Create.g.cs

#nullable enable

namespace G
{
    public partial class DatasetsClient
    {
        partial void PrepareCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string name,
            ref global::G.DatasetType type,
            ref bool? keepOriginalFile,
            ref bool? skipMalformedInput,
            global::System.Collections.Generic.IList<string>? keepFields,
            global::System.Collections.Generic.IList<string>? optionalFields,
            ref string? textSeparator,
            ref string? csvDelimiter,
            ref string? xClientName,
            global::G.DatasetDytngn request);
        partial void PrepareCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string name,
            global::G.DatasetType type,
            bool? keepOriginalFile,
            bool? skipMalformedInput,
            global::System.Collections.Generic.IList<string>? keepFields,
            global::System.Collections.Generic.IList<string>? optionalFields,
            string? textSeparator,
            string? csvDelimiter,
            string? xClientName,
            global::G.DatasetDytngn request);
        partial void ProcessCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a Dataset<br/>
        /// Create a dataset by uploading a file. See ['Dataset Creation'](https://docs.cohere.com/docs/datasets#dataset-creation) for more information.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">
        /// The type of the dataset
        /// </param>
        /// <param name="keepOriginalFile"></param>
        /// <param name="skipMalformedInput"></param>
        /// <param name="keepFields"></param>
        /// <param name="optionalFields"></param>
        /// <param name="textSeparator"></param>
        /// <param name="csvDelimiter"></param>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DatasetsCreateResponse> CreateAsync(
            string name,
            global::G.DatasetType type,

            global::G.DatasetDytngn request,
            bool? keepOriginalFile = default,
            bool? skipMalformedInput = default,
            global::System.Collections.Generic.IList<string>? keepFields = default,
            global::System.Collections.Generic.IList<string>? optionalFields = default,
            string? textSeparator = default,
            string? csvDelimiter = default,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateArguments(
                httpClient: HttpClient,
                name: ref name,
                type: ref type,
                keepOriginalFile: ref keepOriginalFile,
                skipMalformedInput: ref skipMalformedInput,
                keepFields: keepFields,
                optionalFields: optionalFields,
                textSeparator: ref textSeparator,
                csvDelimiter: ref csvDelimiter,
                xClientName: ref xClientName,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/datasets",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("name", name)
                .AddRequiredParameter("type", type.ToValueString())
                .AddOptionalParameter("keep_original_file", keepOriginalFile?.ToString().ToLowerInvariant())
                .AddOptionalParameter("skip_malformed_input", skipMalformedInput?.ToString().ToLowerInvariant())
                .AddOptionalParameter("keep_fields", keepFields, delimiter: ",", explode: true)
                .AddOptionalParameter("optional_fields", optionalFields, delimiter: ",", explode: true)
                .AddOptionalParameter("text_separator", textSeparator)
                .AddOptionalParameter("csv_delimiter", csvDelimiter) 
                ; 
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

            if (xClientName != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("X-Client-Name", xClientName.ToString());
            }

            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{name}"),
                name: "\"name\"");
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{type.ToValueString()}"),
                name: "\"type\"");
            if (keepOriginalFile != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{keepOriginalFile}"),
                    name: "\"keep_original_file\"");
            } 
            if (skipMalformedInput != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{skipMalformedInput}"),
                    name: "\"skip_malformed_input\"");
            } 
            if (keepFields != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(keepFields, x => x))}]"),
                    name: "\"keep_fields\"");
            } 
            if (optionalFields != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(optionalFields, x => x))}]"),
                    name: "\"optional_fields\"");
            } 
            if (textSeparator != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{textSeparator}"),
                    name: "\"text_separator\"");
            } 
            if (csvDelimiter != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{csvDelimiter}"),
                    name: "\"csv_delimiter\"");
            } 
            if (xClientName != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{xClientName}"),
                    name: "\"X-Client-Name\"");
            }
            var __contentData = new global::System.Net.Http.ByteArrayContent(request.Data ?? global::System.Array.Empty<byte>());
            __httpRequestContent.Add(
                content: __contentData,
                name: "\"data\"",
                fileName: request.Dataname != null ? $"\"{request.Dataname}\"" : string.Empty);
            if (__contentData.Headers.ContentDisposition != null)
            {
                __contentData.Headers.ContentDisposition.FileNameStar = null;
            }
            if (request.EvalData != default)
            {

                var __contentEvalData = new global::System.Net.Http.ByteArrayContent(request.EvalData ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentEvalData,
                    name: "\"eval_data\"",
                    fileName: request.EvalDataname != null ? $"\"{request.EvalDataname}\"" : string.Empty);
                if (__contentEvalData.Headers.ContentDisposition != null)
                {
                    __contentEvalData.Headers.ContentDisposition.FileNameStar = null;
                }
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                name: name,
                type: type,
                keepOriginalFile: keepOriginalFile,
                skipMalformedInput: skipMalformedInput,
                keepFields: keepFields,
                optionalFields: optionalFields,
                textSeparator: textSeparator,
                csvDelimiter: csvDelimiter,
                xClientName: xClientName,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // This error is returned when the request is not well formed. This could be because:   - JSON is invalid   - The request is missing required fields   - The request contains an invalid combination of fields 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.NotFoundErrorBody13? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.NotFoundErrorBody13.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.NotFoundErrorBody13.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.NotFoundErrorBody13>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
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
            // This error indicates that the operation attempted to be performed is not allowed. This could be because:   - The api token is invalid   - The user does not have the necessary permissions 
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::G.UnauthorizedErrorBody25? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::G.UnauthorizedErrorBody25.FromJson(__content_401, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::G.UnauthorizedErrorBody25.FromJson(__content_401, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException<global::G.UnauthorizedErrorBody25>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
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
            // This error indicates that the operation attempted to be performed is not allowed. This could be because:   - The api token is invalid   - The user does not have the necessary permissions 
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                global::G.BadRequestErrorBody13? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::G.BadRequestErrorBody13.FromJson(__content_403, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = global::G.BadRequestErrorBody13.FromJson(__content_403, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::G.ApiException<global::G.BadRequestErrorBody13>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
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
            // This error is returned when a resource is not found. This could be because:   - The endpoint does not exist   - The resource does not exist eg model id, dataset id 
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::G.UnauthorizedErrorBody26? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::G.UnauthorizedErrorBody26.FromJson(__content_404, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::G.UnauthorizedErrorBody26.FromJson(__content_404, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::G.ApiException<global::G.UnauthorizedErrorBody26>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
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
            // This error is returned when the request is not well formed. This could be because:   - JSON is invalid   - The request is missing required fields   - The request contains an invalid combination of fields 
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.UnprocessableEntityErrorBody13? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::G.UnprocessableEntityErrorBody13.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::G.UnprocessableEntityErrorBody13.FromJson(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::G.UnprocessableEntityErrorBody13>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Too many requests
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                global::G.GatewayTimeoutErrorBody13? __value_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_429 = global::G.GatewayTimeoutErrorBody13.FromJson(__content_429, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_429 = global::G.GatewayTimeoutErrorBody13.FromJson(__content_429, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::G.ApiException<global::G.GatewayTimeoutErrorBody13>(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseObject = __value_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when a request or response contains a deny-listed token. 
            if ((int)__response.StatusCode == 498)
            {
                string? __content_498 = null;
                global::System.Exception? __exception_498 = null;
                global::G.ForbiddenErrorBody13? __value_498 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_498 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_498 = global::G.ForbiddenErrorBody13.FromJson(__content_498, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_498 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_498 = global::G.ForbiddenErrorBody13.FromJson(__content_498, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_498 = __ex;
                }

                throw new global::G.ApiException<global::G.ForbiddenErrorBody13>(
                    message: __content_498 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_498,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_498,
                    ResponseObject = __value_498,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when a request is cancelled by the user. 
            if ((int)__response.StatusCode == 499)
            {
                string? __content_499 = null;
                global::System.Exception? __exception_499 = null;
                global::G.InternalServerErrorBody13? __value_499 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_499 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_499 = global::G.InternalServerErrorBody13.FromJson(__content_499, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_499 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_499 = global::G.InternalServerErrorBody13.FromJson(__content_499, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_499 = __ex;
                }

                throw new global::G.ApiException<global::G.InternalServerErrorBody13>(
                    message: __content_499 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_499,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_499,
                    ResponseObject = __value_499,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when an uncategorised internal server error occurs. 
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                global::G.ServiceUnavailableErrorBody13? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::G.ServiceUnavailableErrorBody13.FromJson(__content_500, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::G.ServiceUnavailableErrorBody13.FromJson(__content_500, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::G.ApiException<global::G.ServiceUnavailableErrorBody13>(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
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
            // This error is returned when the requested feature is not implemented. 
            if ((int)__response.StatusCode == 501)
            {
                string? __content_501 = null;
                global::System.Exception? __exception_501 = null;
                global::G.NotImplementedErrorBody13? __value_501 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_501 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_501 = global::G.NotImplementedErrorBody13.FromJson(__content_501, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_501 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_501 = global::G.NotImplementedErrorBody13.FromJson(__content_501, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_501 = __ex;
                }

                throw new global::G.ApiException<global::G.NotImplementedErrorBody13>(
                    message: __content_501 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_501,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_501,
                    ResponseObject = __value_501,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when the service is unavailable. This could be due to:   - Too many users trying to access the service at the same time 
            if ((int)__response.StatusCode == 503)
            {
                string? __content_503 = null;
                global::System.Exception? __exception_503 = null;
                global::G.TooManyRequestsErrorBody13? __value_503 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_503 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_503 = global::G.TooManyRequestsErrorBody13.FromJson(__content_503, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_503 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_503 = global::G.TooManyRequestsErrorBody13.FromJson(__content_503, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_503 = __ex;
                }

                throw new global::G.ApiException<global::G.TooManyRequestsErrorBody13>(
                    message: __content_503 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_503,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_503,
                    ResponseObject = __value_503,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when a request to the server times out. This could be due to:   - An internal services taking too long to respond 
            if ((int)__response.StatusCode == 504)
            {
                string? __content_504 = null;
                global::System.Exception? __exception_504 = null;
                global::G.InvalidTokenErrorBody13? __value_504 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_504 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_504 = global::G.InvalidTokenErrorBody13.FromJson(__content_504, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_504 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_504 = global::G.InvalidTokenErrorBody13.FromJson(__content_504, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_504 = __ex;
                }

                throw new global::G.ApiException<global::G.InvalidTokenErrorBody13>(
                    message: __content_504 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_504,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_504,
                    ResponseObject = __value_504,
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
                ProcessCreateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.DatasetsCreateResponse.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
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
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::G.DatasetsCreateResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

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
        }
        /// <summary>
        /// Create a Dataset<br/>
        /// Create a dataset by uploading a file. See ['Dataset Creation'](https://docs.cohere.com/docs/datasets#dataset-creation) for more information.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">
        /// The type of the dataset
        /// </param>
        /// <param name="keepOriginalFile"></param>
        /// <param name="skipMalformedInput"></param>
        /// <param name="keepFields"></param>
        /// <param name="optionalFields"></param>
        /// <param name="textSeparator"></param>
        /// <param name="csvDelimiter"></param>
        /// <param name="xClientName"></param>
        /// <param name="data">
        /// The file to upload
        /// </param>
        /// <param name="dataname">
        /// The file to upload
        /// </param>
        /// <param name="evalData">
        /// An optional evaluation file to upload
        /// </param>
        /// <param name="evalDataname">
        /// An optional evaluation file to upload
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DatasetsCreateResponse> CreateAsync(
            string name,
            global::G.DatasetType type,
            byte[] data,
            string dataname,
            bool? keepOriginalFile = default,
            bool? skipMalformedInput = default,
            global::System.Collections.Generic.IList<string>? keepFields = default,
            global::System.Collections.Generic.IList<string>? optionalFields = default,
            string? textSeparator = default,
            string? csvDelimiter = default,
            string? xClientName = default,
            byte[]? evalData = default,
            string? evalDataname = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.DatasetDytngn
            {
                Data = data,
                Dataname = dataname,
                EvalData = evalData,
                EvalDataname = evalDataname,
            };

            return await CreateAsync(
                name: name,
                type: type,
                keepOriginalFile: keepOriginalFile,
                skipMalformedInput: skipMalformedInput,
                keepFields: keepFields,
                optionalFields: optionalFields,
                textSeparator: textSeparator,
                csvDelimiter: csvDelimiter,
                xClientName: xClientName,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}