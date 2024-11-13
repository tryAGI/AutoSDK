//HintName: G.ResourceClient.ResourceDeleteTranscript.g.cs

#nullable enable

namespace G
{
    public partial class ResourceClient
    {
        partial void PrepareResourceDeleteTranscriptArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? projectIdKey,
            ref global::System.Guid? id,
            ref global::System.Guid? creator,
            ref global::System.Guid? projectId,
            ref global::System.Guid? resourceId,
            ref string? dataPath,
            ref global::System.DateTime? created);
        partial void PrepareResourceDeleteTranscriptRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? projectIdKey,
            global::System.Guid? id,
            global::System.Guid? creator,
            global::System.Guid? projectId,
            global::System.Guid? resourceId,
            string? dataPath,
            global::System.DateTime? created);
        partial void ProcessResourceDeleteTranscriptResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessResourceDeleteTranscriptResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// DeleteTranscript.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="id"></param>
        /// <param name="creator"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="dataPath"></param>
        /// <param name="created"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> ResourceDeleteTranscriptAsync(
            string? token = default,
            string? projectIdKey = default,
            global::System.Guid? id = default,
            global::System.Guid? creator = default,
            global::System.Guid? projectId = default,
            global::System.Guid? resourceId = default,
            string? dataPath = default,
            global::System.DateTime? created = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareResourceDeleteTranscriptArguments(
                httpClient: HttpClient,
                token: ref token,
                projectIdKey: ref projectIdKey,
                id: ref id,
                creator: ref creator,
                projectId: ref projectId,
                resourceId: ref resourceId,
                dataPath: ref dataPath,
                created: ref created);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/resource/deletetranscript",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("ProjectIdKey", projectIdKey) 
                .AddOptionalParameter("Id", id?.ToString()) 
                .AddOptionalParameter("Creator", creator?.ToString()) 
                .AddOptionalParameter("ProjectId", projectId?.ToString()) 
                .AddOptionalParameter("ResourceId", resourceId?.ToString()) 
                .AddOptionalParameter("DataPath", dataPath) 
                .AddOptionalParameter("Created", created?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareResourceDeleteTranscriptRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                projectIdKey: projectIdKey,
                id: id,
                creator: creator,
                projectId: projectId,
                resourceId: resourceId,
                dataPath: dataPath,
                created: created);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessResourceDeleteTranscriptResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Token is null.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                string? __value_400 = null;
                if (ReadResponseAsString)
                {
                    __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content_400, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<string?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__contentStream_400)));
                }

                throw new global::G.ApiException<string>(
                    message: __response.ReasonPhrase ?? string.Empty,
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
            // Token is invalid.
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                string? __value_401 = null;
                if (ReadResponseAsString)
                {
                    __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content_401, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_401 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<string?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__contentStream_401)));
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

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessResourceDeleteTranscriptResponseContent(
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

                return __content;
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

                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                return __content;
            }
        }
    }
}