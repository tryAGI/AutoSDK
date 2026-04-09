//HintName: G.IngestClient.PostSource.g.cs

#nullable enable

namespace G
{
    public partial class IngestClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_PostSourceSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "",
                        SchemeId = "DeveloperKey",
                        Location = "",
                        Name = "",
                        FriendlyName = "Authorization",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_PostSourceSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_PostSourceSecurityRequirement0,
            };
        partial void PreparePostSourceArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.Source request);
        partial void PreparePostSourceRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.Source request);
        partial void ProcessPostSourceResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPostSourceResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Fetch Source<br/>
        /// Queue a source file to be fetched from a URL and stored by Shotstack. Source files can be videos, images, audio<br/>
        /// files and fonts. Once ingested, new [output renditions](#tocs_outputs) can be created from the source file.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/ingest/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.QueuedSourceResponse> PostSourceAsync(

            global::G.Source request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePostSourceArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_PostSourceSecurityRequirements,
                operationName: "PostSourceAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/ingest/v1/sources",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePostSourceRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPostSourceResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // A list of validation and other errors
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.IngestErrorResponse? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.IngestErrorResponse.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.IngestErrorResponse.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.IngestErrorResponse>(
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
                ProcessPostSourceResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.QueuedSourceResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.QueuedSourceResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Fetch Source<br/>
        /// Queue a source file to be fetched from a URL and stored by Shotstack. Source files can be videos, images, audio<br/>
        /// files and fonts. Once ingested, new [output renditions](#tocs_outputs) can be created from the source file.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/ingest/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="url">
        /// The URL of the file to be ingested. The URL must be publicly accessible or include credentials.<br/>
        /// Example: https://github.com/shotstack/test-media/raw/main/captioning/scott-ko.mp4
        /// </param>
        /// <param name="outputs">
        /// The output renditions and transformations that should be generated from the source file.
        /// </param>
        /// <param name="destinations">
        /// A destination is a location where assets can be sent to for serving or hosting. Videos, images and audio files that are rendered by the [Edit API](#shotstack-edit) and [source](#tocs_source) and [rendition](#tocs_rendition) files generated by the [Ingest API](#shotstack-ingest) can be sent to destinations. You can also fetch a file from any public URL and [transfer](#transfer-asset) it to a destination. A file can be sent to one or more destinations including 3rd party destinations.<br/>
        /// By default all ingested and generated assets are automatically sent to the [Shotstack hosting destination](https://shotstack.io/docs/guide/serving-assets/hosting/). You can [opt-out](https://shotstack.io/docs/guide/serving-assets/self-host/) from by setting the Shotstack destination **exclude** property to **true**.
        /// </param>
        /// <param name="callback">
        /// An optional webhook callback URL used to receive status notifications when sources are uploaded and renditions processed.<br/>
        /// Example: https://my-server.com/callback.php
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.QueuedSourceResponse> PostSourceAsync(
            string? url = default,
            global::G.Outputs? outputs = default,
            global::G.Destinations? destinations = default,
            string? callback = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.Source
            {
                Url = url,
                Outputs = outputs,
                Destinations = destinations,
                Callback = callback,
            };

            return await PostSourceAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}