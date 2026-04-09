//HintName: G.EditClient.PostRender.g.cs

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial class EditClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_PostRenderSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "",
                        Location = "",
                        Name = "",
                        FriendlyName = "Authorization",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_PostRenderSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_PostRenderSecurityRequirement0,
            };
        partial void PreparePostRenderArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.Edit request);
        partial void PreparePostRenderRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.Edit request);
        partial void ProcessPostRenderResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPostRenderResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Render Asset<br/>
        /// Queue and render the contents of an [Edit](#tocs_edit) as a video, image or audio file.<br/>
        /// **Rendering Process:**<br/>
        /// 1. **Validation**: The edit JSON is validated<br/>
        /// 2. **Download**: All assets are downloaded and cached  <br/>
        /// 3. **Preprocessing**: Video assets are automatically processed to fix compatibility issues<br/>
        /// 4. **Rendering**: The timeline is rendered using the processed assets<br/>
        /// 5. **Output**: The final media file is generated and stored<br/>
        /// **Video Preprocessing:**<br/>
        /// Video assets undergo automatic preprocessing to ensure compatibility. You can force <br/>
        /// preprocessing by setting `"transcode": true` on video assets. See [Preprocessing](#preprocessing) <br/>
        /// for more details.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/edit/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.QueuedResponse> PostRenderAsync(

            global::G.Edit request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePostRenderArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_PostRenderSecurityRequirements,
                operationName: "PostRenderAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/edit/v1/render",
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
            PreparePostRenderRequest(
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
            ProcessPostRenderResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

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
                ProcessPostRenderResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.QueuedResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.QueuedResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Render Asset<br/>
        /// Queue and render the contents of an [Edit](#tocs_edit) as a video, image or audio file.<br/>
        /// **Rendering Process:**<br/>
        /// 1. **Validation**: The edit JSON is validated<br/>
        /// 2. **Download**: All assets are downloaded and cached  <br/>
        /// 3. **Preprocessing**: Video assets are automatically processed to fix compatibility issues<br/>
        /// 4. **Rendering**: The timeline is rendered using the processed assets<br/>
        /// 5. **Output**: The final media file is generated and stored<br/>
        /// **Video Preprocessing:**<br/>
        /// Video assets undergo automatic preprocessing to ensure compatibility. You can force <br/>
        /// preprocessing by setting `"transcode": true` on video assets. See [Preprocessing](#preprocessing) <br/>
        /// for more details.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/edit/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="timeline">
        /// A timeline represents the contents of a video edit over time, an audio edit over time, in seconds, or an image layout. A timeline consists of layers called tracks. Tracks are composed of titles, images, audio, html or video segments referred to as clips which are placed along the track at specific starting point and lasting for a specific amount of time.
        /// </param>
        /// <param name="output">
        /// The output format, render range and type of media to generate.
        /// </param>
        /// <param name="merge">
        /// An array of key/value pairs that provides an easy way to create templates with placeholders. The placeholders can be used to find and replace keys with values. For example you can search for the placeholder `{{NAME}}` and replace it with the value `Jane`. 
        /// </param>
        /// <param name="callback">
        /// An optional webhook callback URL used to receive status notifications when a render completes or fails. Notifications are also sent when a rendered video is sent to an output  [destination](https://shotstack.io/docs/guide/serving-assets/destinations/).<br/>
        /// See [webhooks](https://shotstack.io/docs/guide/architecting-an-application/webhooks/) for more details.<br/>
        /// Example: https://my-server.com/callback.php
        /// </param>
        /// <param name="instance">
        /// The render instance type to use for processing the edit. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`s1` - standard instance (default)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`s2` - standard instance with more resources&lt;/li&gt;<br/>
        ///   &lt;li&gt;`a1` - accelerated instance for faster rendering&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Default Value: s1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.QueuedResponse> PostRenderAsync(
            global::G.Timeline timeline,
            global::G.Output output,
            global::System.Collections.Generic.IList<global::G.MergeField>? merge = default,
            string? callback = default,
            global::G.EditInstance? instance = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.Edit
            {
                Timeline = timeline,
                Output = output,
                Merge = merge,
                Callback = callback,
                Instance = instance,
            };

            return await PostRenderAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}