//HintName: G.Api.CreateJobs.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {


        private static readonly global::G.EndPointSecurityRequirement s_CreateJobsSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "BearerAuth",
                        Location = "Header",
                        Name = "Authorization",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_CreateJobsSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_CreateJobsSecurityRequirement0,
            };
        partial void PrepareCreateJobsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xSmProcessingData,
            global::G.CreateJobsRequest request);
        partial void PrepareCreateJobsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xSmProcessingData,
            global::G.CreateJobsRequest request);
        partial void ProcessCreateJobsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateJobsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a new job
        /// </summary>
        /// <param name="xSmProcessingData"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// import { BatchClient } from "@speechmatics/batch-client";<br/>
        /// const client = new BatchClient({ apiKey: "YOUR_API_KEY" });<br/>
        /// // This is to get a File handle in NodeJS<br/>
        /// // In the browser, you can pass a File object from a form input, or similar<br/>
        /// const blob = await openAsBlob("PATH_TO_FILE");<br/>
        /// const file = new File([blob], "your_filename");<br/>
        /// const response = await client.createTranscriptionJob({<br/>
        ///   file,<br/>
        ///   config: {<br/>
        ///     type: "transcription",<br/>
        ///     transcription_config: {<br/>
        ///       operating_point: "enhanced",<br/>
        ///       language: "en",<br/>
        ///     },<br/>
        ///   },<br/>
        /// });<br/>
        /// const json = await response.json();<br/>
        /// console.log(json);
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::G.CreateJobResponse> CreateJobsAsync(

            global::G.CreateJobsRequest request,
            string? xSmProcessingData = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateJobsArguments(
                httpClient: HttpClient,
                xSmProcessingData: ref xSmProcessingData,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateJobsSecurityRequirements,
                operationName: "CreateJobsAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/jobs",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            var __cookies = new global::System.Collections.Generic.List<string>();
            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Cookie")
                {
                    var __cookieValue = global::System.Uri.EscapeDataString(__authorization.Value);
                    __cookies.Add($"{__authorization.Name}={__cookieValue}");
                }
            }

            if (__cookies.Count > 0)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", __cookies));
            }

            if (xSmProcessingData != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("X-SM-Processing-Data", xSmProcessingData.ToString());
            }

            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (xSmProcessingData != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{xSmProcessingData}"),
                    name: "\"X-SM-Processing-Data\"");
            }
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Config}"),
                name: "\"config\"");
            if (request.DataFile != default)
            {

                var __contentDataFile = new global::System.Net.Http.ByteArrayContent(request.DataFile ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentDataFile,
                    name: "\"data_file\"",
                    fileName: request.DataFilename != null ? $"\"{request.DataFilename}\"" : string.Empty);
                if (__contentDataFile.Headers.ContentDisposition != null)
                {
                    __contentDataFile.Headers.ContentDisposition.FileNameStar = null;
                }
            } 
            if (request.TextFile != default)
            {

                var __contentTextFile = new global::System.Net.Http.ByteArrayContent(request.TextFile ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentTextFile,
                    name: "\"text_file\"",
                    fileName: request.TextFilename != null ? $"\"{request.TextFilename}\"" : string.Empty);
                if (__contentTextFile.Headers.ContentDisposition != null)
                {
                    __contentTextFile.Headers.ContentDisposition.FileNameStar = null;
                }
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateJobsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xSmProcessingData: xSmProcessingData,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateJobsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad request
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.ErrorResponse? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.ErrorResponse.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.ErrorResponse.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.ErrorResponse>(
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
            // Unauthorized
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::G.ErrorResponse? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::G.ErrorResponse.FromJson(__content_401, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::G.ErrorResponse.FromJson(__content_401, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException<global::G.ErrorResponse>(
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
            // Forbidden
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                global::G.ErrorResponse? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::G.ErrorResponse.FromJson(__content_403, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = global::G.ErrorResponse.FromJson(__content_403, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::G.ApiException<global::G.ErrorResponse>(
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
            // Gone
            if ((int)__response.StatusCode == 410)
            {
                string? __content_410 = null;
                global::System.Exception? __exception_410 = null;
                global::G.ErrorResponse? __value_410 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_410 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_410 = global::G.ErrorResponse.FromJson(__content_410, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_410 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_410 = global::G.ErrorResponse.FromJson(__content_410, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_410 = __ex;
                }

                throw new global::G.ApiException<global::G.ErrorResponse>(
                    message: __content_410 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_410,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_410,
                    ResponseObject = __value_410,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Rate Limited
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
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
                global::System.Exception? __exception_500 = null;
                global::G.ErrorResponse? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::G.ErrorResponse.FromJson(__content_500, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::G.ErrorResponse.FromJson(__content_500, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::G.ApiException<global::G.ErrorResponse>(
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
                ProcessCreateJobsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.CreateJobResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.CreateJobResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Create a new job
        /// </summary>
        /// <param name="xSmProcessingData"></param>
        /// <param name="config">
        /// JSON containing a [`JobConfig`](/speech-to-text/batch/input#jobconfig-schema) model indicating the type and parameters for the recognition job.
        /// </param>
        /// <param name="dataFile">
        /// The data file to be processed. Alternatively the data file can be fetched from a url specified in `JobConfig`.
        /// </param>
        /// <param name="dataFilename">
        /// The data file to be processed. Alternatively the data file can be fetched from a url specified in `JobConfig`.
        /// </param>
        /// <param name="textFile">
        /// For alignment jobs, the text file that the data file should be aligned to.
        /// </param>
        /// <param name="textFilename">
        /// For alignment jobs, the text file that the data file should be aligned to.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateJobResponse> CreateJobsAsync(
            string config,
            string? xSmProcessingData = default,
            byte[]? dataFile = default,
            string? dataFilename = default,
            byte[]? textFile = default,
            string? textFilename = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateJobsRequest
            {
                Config = config,
                DataFile = dataFile,
                DataFilename = dataFilename,
                TextFile = textFile,
                TextFilename = textFilename,
            };

            return await CreateJobsAsync(
                xSmProcessingData: xSmProcessingData,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}