//HintName: G.ObservationsClient.ObservationsGetMany.g.cs

#nullable enable

namespace G
{
    public partial class ObservationsClient
    {
        partial void PrepareObservationsGetManyArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? fields,
            ref string? expandMetadata,
            ref int? limit,
            ref string? cursor,
            ref bool? parseIoAsJson,
            ref string? name,
            ref string? userId,
            ref string? type,
            ref string? traceId,
            ref global::G.ObservationLevel? level,
            ref string? parentObservationId,
            global::System.Collections.Generic.IList<string>? environment,
            ref global::System.DateTime? fromStartTime,
            ref global::System.DateTime? toStartTime,
            ref string? version,
            ref string? filter);
        partial void PrepareObservationsGetManyRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? fields,
            string? expandMetadata,
            int? limit,
            string? cursor,
            bool? parseIoAsJson,
            string? name,
            string? userId,
            string? type,
            string? traceId,
            global::G.ObservationLevel? level,
            string? parentObservationId,
            global::System.Collections.Generic.IList<string>? environment,
            global::System.DateTime? fromStartTime,
            global::System.DateTime? toStartTime,
            string? version,
            string? filter);
        partial void ProcessObservationsGetManyResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessObservationsGetManyResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get a list of observations with cursor-based pagination and flexible field selection.<br/>
        /// ## Cursor-based Pagination<br/>
        /// This endpoint uses cursor-based pagination for efficient traversal of large datasets.<br/>
        /// The cursor is returned in the response metadata and should be passed in subsequent requests<br/>
        /// to retrieve the next page of results.<br/>
        /// ## Field Selection<br/>
        /// Use the `fields` parameter to control which observation fields are returned:<br/>
        /// - `core` - Always included: id, traceId, startTime, endTime, projectId, parentObservationId, type<br/>
        /// - `basic` - name, level, statusMessage, version, environment, bookmarked, public, userId, sessionId<br/>
        /// - `time` - completionStartTime, createdAt, updatedAt<br/>
        /// - `io` - input, output<br/>
        /// - `metadata` - metadata (truncated to 200 chars by default, use `expandMetadata` to get full values)<br/>
        /// - `model` - providedModelName, internalModelId, modelParameters<br/>
        /// - `usage` - usageDetails, costDetails, totalCost<br/>
        /// - `prompt` - promptId, promptName, promptVersion<br/>
        /// - `metrics` - latency, timeToFirstToken<br/>
        /// If not specified, `core` and `basic` field groups are returned.<br/>
        /// ## Filters<br/>
        /// Multiple filtering options are available via query parameters or the structured `filter` parameter.<br/>
        /// When using the `filter` parameter, it takes precedence over individual query parameter filters.
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="expandMetadata"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="parseIoAsJson"></param>
        /// <param name="name"></param>
        /// <param name="userId"></param>
        /// <param name="type"></param>
        /// <param name="traceId"></param>
        /// <param name="level"></param>
        /// <param name="parentObservationId"></param>
        /// <param name="environment"></param>
        /// <param name="fromStartTime"></param>
        /// <param name="toStartTime"></param>
        /// <param name="version"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ObservationsV2Response> ObservationsGetManyAsync(
            string? fields = default,
            string? expandMetadata = default,
            int? limit = default,
            string? cursor = default,
            bool? parseIoAsJson = default,
            string? name = default,
            string? userId = default,
            string? type = default,
            string? traceId = default,
            global::G.ObservationLevel? level = default,
            string? parentObservationId = default,
            global::System.Collections.Generic.IList<string>? environment = default,
            global::System.DateTime? fromStartTime = default,
            global::System.DateTime? toStartTime = default,
            string? version = default,
            string? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareObservationsGetManyArguments(
                httpClient: HttpClient,
                fields: ref fields,
                expandMetadata: ref expandMetadata,
                limit: ref limit,
                cursor: ref cursor,
                parseIoAsJson: ref parseIoAsJson,
                name: ref name,
                userId: ref userId,
                type: ref type,
                traceId: ref traceId,
                level: ref level,
                parentObservationId: ref parentObservationId,
                environment: environment,
                fromStartTime: ref fromStartTime,
                toStartTime: ref toStartTime,
                version: ref version,
                filter: ref filter);

            var levelValue = level switch
            {
                global::G.ObservationLevel.Debug => "DEBUG",
                global::G.ObservationLevel.Default => "DEFAULT",
                global::G.ObservationLevel.Warning => "WARNING",
                global::G.ObservationLevel.Error => "ERROR",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/public/v2/observations",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("fields", fields)
                .AddOptionalParameter("expandMetadata", expandMetadata)
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("cursor", cursor)
                .AddOptionalParameter("parseIoAsJson", parseIoAsJson?.ToString().ToLowerInvariant())
                .AddOptionalParameter("name", name)
                .AddOptionalParameter("userId", userId)
                .AddOptionalParameter("type", type)
                .AddOptionalParameter("traceId", traceId)
                .AddOptionalParameter("level", level?.ToValueString())
                .AddOptionalParameter("parentObservationId", parentObservationId)
                .AddOptionalParameter("environment", environment, delimiter: ",", explode: true)
                .AddOptionalParameter("fromStartTime", fromStartTime?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("toStartTime", toStartTime?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("version", version)
                .AddOptionalParameter("filter", filter) 
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareObservationsGetManyRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                fields: fields,
                expandMetadata: expandMetadata,
                limit: limit,
                cursor: cursor,
                parseIoAsJson: parseIoAsJson,
                name: name,
                userId: userId,
                type: type,
                traceId: traceId,
                level: level,
                parentObservationId: parentObservationId,
                environment: environment,
                fromStartTime: fromStartTime,
                toStartTime: toStartTime,
                version: version,
                filter: filter);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessObservationsGetManyResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                string? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<string>(
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
            // 
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                string? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content_401, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content_401, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException<string>(
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
            // 
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                string? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content_403, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content_403, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::G.ApiException<string>(
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
            // 
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                string? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content_404, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content_404, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::G.ApiException<string>(
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
            // 
            if ((int)__response.StatusCode == 405)
            {
                string? __content_405 = null;
                global::System.Exception? __exception_405 = null;
                string? __value_405 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_405 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_405 = global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content_405, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_405 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_405 = global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content_405, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_405 = __ex;
                }

                throw new global::G.ApiException<string>(
                    message: __content_405 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_405,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_405,
                    ResponseObject = __value_405,
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
                ProcessObservationsGetManyResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.ObservationsV2Response.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.ObservationsV2Response.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
    }
}