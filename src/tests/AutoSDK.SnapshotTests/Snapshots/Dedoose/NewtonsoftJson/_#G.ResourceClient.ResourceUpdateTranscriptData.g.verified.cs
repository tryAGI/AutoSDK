//HintName: G.ResourceClient.ResourceUpdateTranscriptData.g.cs

#nullable enable

namespace G
{
    public partial class ResourceClient
    {
        partial void PrepareResourceUpdateTranscriptDataArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? projectIdKey,
            ref global::System.Guid? id,
            ref global::System.Guid? creator,
            ref global::System.Guid? projectId,
            ref global::System.Guid? resourceId,
            ref string? dataPath,
            ref global::System.DateTime? created,
            ref string? transcriptData,
            global::System.Collections.Generic.IList<global::G.TranscriptSyncItem>? syncItems);
        partial void PrepareResourceUpdateTranscriptDataRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? projectIdKey,
            global::System.Guid? id,
            global::System.Guid? creator,
            global::System.Guid? projectId,
            global::System.Guid? resourceId,
            string? dataPath,
            global::System.DateTime? created,
            string? transcriptData,
            global::System.Collections.Generic.IList<global::G.TranscriptSyncItem>? syncItems);
        partial void ProcessResourceUpdateTranscriptDataResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessResourceUpdateTranscriptDataResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// UpdateTranscriptData.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="id"></param>
        /// <param name="creator"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="dataPath"></param>
        /// <param name="created"></param>
        /// <param name="transcriptData"></param>
        /// <param name="syncItems"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> ResourceUpdateTranscriptDataAsync(
            string? token = default,
            string? projectIdKey = default,
            global::System.Guid? id = default,
            global::System.Guid? creator = default,
            global::System.Guid? projectId = default,
            global::System.Guid? resourceId = default,
            string? dataPath = default,
            global::System.DateTime? created = default,
            string? transcriptData = default,
            global::System.Collections.Generic.IList<global::G.TranscriptSyncItem>? syncItems = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareResourceUpdateTranscriptDataArguments(
                httpClient: HttpClient,
                token: ref token,
                projectIdKey: ref projectIdKey,
                id: ref id,
                creator: ref creator,
                projectId: ref projectId,
                resourceId: ref resourceId,
                dataPath: ref dataPath,
                created: ref created,
                transcriptData: ref transcriptData,
                syncItems: syncItems);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/resource/updatetranscriptdata",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("ProjectIdKey", projectIdKey) 
                .AddOptionalParameter("Id", id?.ToString()) 
                .AddOptionalParameter("Creator", creator?.ToString()) 
                .AddOptionalParameter("ProjectId", projectId?.ToString()) 
                .AddOptionalParameter("ResourceId", resourceId?.ToString()) 
                .AddOptionalParameter("DataPath", dataPath) 
                .AddOptionalParameter("Created", created?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("transcriptData", transcriptData) 
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
            PrepareResourceUpdateTranscriptDataRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                projectIdKey: projectIdKey,
                id: id,
                creator: creator,
                projectId: projectId,
                resourceId: resourceId,
                dataPath: dataPath,
                created: created,
                transcriptData: transcriptData,
                syncItems: syncItems);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessResourceUpdateTranscriptDataResponse(
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
                ProcessResourceUpdateTranscriptDataResponseContent(
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