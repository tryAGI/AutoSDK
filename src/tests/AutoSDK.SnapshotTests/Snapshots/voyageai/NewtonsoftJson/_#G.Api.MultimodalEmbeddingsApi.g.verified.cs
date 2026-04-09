//HintName: G.Api.MultimodalEmbeddingsApi.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {


        private static readonly global::G.EndPointSecurityRequirement s_MultimodalEmbeddingsApiSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "Authorization: Bearer",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_MultimodalEmbeddingsApiSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_MultimodalEmbeddingsApiSecurityRequirement0,
            };
        partial void PrepareMultimodalEmbeddingsApiArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.MultimodalEmbeddingsApiRequest request);
        partial void PrepareMultimodalEmbeddingsApiRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.MultimodalEmbeddingsApiRequest request);
        partial void ProcessMultimodalEmbeddingsApiResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMultimodalEmbeddingsApiResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Multimodal embedding models<br/>
        /// The Voyage multimodal embedding endpoint returns vector representations for a given list of multimodal inputs consisting of text, images, or an interleaving of both modalities.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.MultimodalEmbeddingsApiResponse> MultimodalEmbeddingsApiAsync(

            global::G.MultimodalEmbeddingsApiRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareMultimodalEmbeddingsApiArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_MultimodalEmbeddingsApiSecurityRequirements,
                operationName: "MultimodalEmbeddingsApiAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/multimodalembeddings",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareMultimodalEmbeddingsApiRequest(
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
            ProcessMultimodalEmbeddingsApiResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Client error  <p> This indicates an issue with the request format or frequency. Please see our  [Error Codes](https://docs.voyageai.com/docs/error-codes) guide. </p> 
            if ((int)__response.StatusCode >= 400 && (int)__response.StatusCode <= 499)
            {
                string? __content_4XX = null;
                global::System.Exception? __exception_4XX = null;
                global::G.MultimodalEmbeddingsApiResponse2? __value_4XX = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_4XX = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_4XX = global::G.MultimodalEmbeddingsApiResponse2.FromJson(__content_4XX, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_4XX = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_4XX = global::G.MultimodalEmbeddingsApiResponse2.FromJson(__content_4XX, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_4XX = __ex;
                }

                throw new global::G.ApiException<global::G.MultimodalEmbeddingsApiResponse2>(
                    message: __content_4XX ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_4XX,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_4XX,
                    ResponseObject = __value_4XX,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode >= 500 && (int)__response.StatusCode <= 599)
            {
                string? __content_5XX = null;
                global::System.Exception? __exception_5XX = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_5XX = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_5XX = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_5XX = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_5XX ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_5XX,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_5XX,
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
                ProcessMultimodalEmbeddingsApiResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.MultimodalEmbeddingsApiResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.MultimodalEmbeddingsApiResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Multimodal embedding models<br/>
        /// The Voyage multimodal embedding endpoint returns vector representations for a given list of multimodal inputs consisting of text, images, or an interleaving of both modalities.
        /// </summary>
        /// <param name="inputs">
        /// A list of multimodal inputs to be vectorized.  A single input in the list is a dictionary containing a single key `"content"`, whose value represents a sequence of text and images. &lt;ul&gt;<br/>
        ///   &lt;li&gt; The value of &lt;code&gt;"content"&lt;/code&gt; is a list of dictionaries, each representing a single piece of text or image. The dictionaries have four possible keys:<br/>
        ///       &lt;ol class="nested-ordered-list"&gt;<br/>
        ///           &lt;li&gt; &lt;b&gt;type&lt;/b&gt;: Specifies the type of the piece of the content. Allowed values are &lt;code&gt;text&lt;/code&gt;, &lt;code&gt;image_url&lt;/code&gt;, or &lt;code&gt;image_base64&lt;/code&gt;.&lt;/li&gt;<br/>
        ///           &lt;li&gt; &lt;b&gt;text&lt;/b&gt;: Only present when &lt;code&gt;type&lt;/code&gt; is &lt;code&gt;text&lt;/code&gt;. The value should be a text string.&lt;/li&gt;<br/>
        ///           &lt;li&gt; &lt;b&gt;image_base64&lt;/b&gt;: Only present when &lt;code&gt;type&lt;/code&gt; is &lt;code&gt;image_base64&lt;/code&gt;. The value should be a Base64-encoded image in the &lt;a href="https://developer.mozilla.org/en-US/docs/Web/URI/Schemes/data" target="_blank"&gt;data URL&lt;/a&gt; format &lt;code&gt;data:[&amp;lt;mediatype&amp;gt;];base64,&amp;lt;data&amp;gt;&lt;/code&gt;. Currently supported &lt;code&gt;mediatypes&lt;/code&gt; are: &lt;code&gt;image/png&lt;/code&gt;, &lt;code&gt;image/jpeg&lt;/code&gt;, &lt;code&gt;image/webp&lt;/code&gt;, and &lt;code&gt;image/gif&lt;/code&gt;.&lt;/li&gt;<br/>
        ///           &lt;li&gt; &lt;b&gt;image_url&lt;/b&gt;: Only present when &lt;code&gt;type&lt;/code&gt; is &lt;code&gt;image_url&lt;/code&gt;. The value should be a URL linking to the image. We support PNG, JPEG, WEBP, and GIF images.&lt;/li&gt;<br/>
        ///       &lt;/ol&gt;<br/>
        ///   &lt;/li&gt;<br/>
        ///   &lt;li&gt; &lt;b&gt;Note&lt;/b&gt;: Only one of the keys, &lt;code&gt;image_base64&lt;/code&gt; or &lt;code&gt;image_url&lt;/code&gt;, should be present in each dictionary for image data. Consistency is required within a request, meaning each request should use either &lt;code&gt;image_base64&lt;/code&gt; or &lt;code&gt;image_url&lt;/code&gt; exclusively for images, not both.<br/>
        ///   <br/>
        ///   &lt;details&gt; &lt;summary&gt; Example payload where &lt;code&gt;inputs&lt;/code&gt; contains an image as a URL &lt;/summary&gt;<br/>
        ///       <br/>
        ///       The &lt;code&gt;inputs&lt;/code&gt; list contains a single input, which consists of a piece of text and an image (which is provided via a URL).<br/>
        ///       &lt;pre&gt;&lt;code&gt;<br/>
        ///       {<br/>
        ///         "inputs": [<br/>
        ///           {   <br/>
        ///             "content": [<br/>
        ///               {   <br/>
        ///                 "type": "text",<br/>
        ///                 "text": "This is a banana."<br/>
        ///               },  <br/>
        ///               {   <br/>
        ///                 "type": "image_url",<br/>
        ///                 "image_url": "https://raw.githubusercontent.com/voyage-ai/voyage-multimodal-3/refs/heads/main/images/banana.jpg"<br/>
        ///               }   <br/>
        ///             ]   <br/>
        ///           }   <br/>
        ///         ],  <br/>
        ///         "model": "voyage-multimodal-3"<br/>
        ///       }<br/>
        ///       &lt;/code&gt;&lt;/pre&gt;<br/>
        ///   &lt;/details&gt;<br/>
        ///   &lt;details&gt; &lt;summary&gt; Example payload where &lt;code&gt;inputs&lt;/code&gt; contains a Base64 image &lt;/summary&gt;<br/>
        ///       <br/>
        ///       Below is an equivalent example to the one above where the image content is a Base64 image instead of a URL. (Base64 images can be lengthy, so the example only shows a shortened version.)<br/>
        ///       &lt;pre&gt;&lt;code&gt;  <br/>
        ///       {<br/>
        ///         "inputs": [<br/>
        ///           {   <br/>
        ///             "content": [<br/>
        ///               {   <br/>
        ///                 "type": "text",<br/>
        ///                 "text": "This is a banana."<br/>
        ///               },  <br/>
        ///               {   <br/>
        ///                 "type": "image_base64",<br/>
        ///                 "image_base64": "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAA..."<br/>
        ///               }   <br/>
        ///             ]   <br/>
        ///           }   <br/>
        ///         ],  <br/>
        ///         "model": "voyage-multimodal-3"<br/>
        ///       }<br/>
        ///       &lt;/code&gt;&lt;/pre&gt;<br/>
        ///   &lt;/details&gt;<br/>
        ///   &lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// &lt;span style="font-size: 13px;"&gt;The following constraints apply to the &lt;code&gt;inputs&lt;/code&gt; list:&lt;/span&gt; &lt;ul&gt;<br/>
        ///     &lt;li&gt; The list must not contain more than 1000 inputs. &lt;/li&gt;<br/>
        ///     &lt;li&gt; Each image must not contain more than 16 million pixels or be larger than 20 MB in size. &lt;/li&gt;<br/>
        ///     &lt;li&gt; With every 560 pixels of an image being counted as a token, each input in the list must not exceed 32,000 tokens, and the total number of tokens across all inputs must not exceed 320,000. &lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </param>
        /// <param name="model">
        /// Name of the model. Currently, the only supported model is `voyage-multimodal-3`.
        /// </param>
        /// <param name="inputType">
        /// Type of the input. Defaults to `null`. Other options: `query`, `document`. &lt;ul&gt; &lt;li&gt; When `input_type` is `null`, the embedding model directly converts the `inputs` into numerical vectors. For retrieval/search purposes, where a "query", which can be text or image in this case, is used to search for relevant information among a collection of data referred to as "documents," we recommend specifying whether your `inputs` are intended as queries or documents by setting `input_type` to `query` or `document`, respectively. In these cases, Voyage automatically prepends a prompt to your `inputs` before vectorizing them, creating vectors more tailored for retrieval/search tasks. Since inputs can be multimodal, "queries" and "documents" can be text, images, or an interleaving of both modalities. Embeddings generated with and without the `input_type` argument are compatible. &lt;/li&gt; &lt;li&gt; For transparency, the following prompts are prepended to your input. &lt;/li&gt;<br/>
        ///   &lt;ul&gt;<br/>
        ///     &lt;li&gt; For &lt;code&gt;query&lt;/code&gt;, the prompt is &lt;i&gt;"Represent the query for retrieving supporting documents: ".&lt;/i&gt; &lt;/li&gt;<br/>
        ///     &lt;li&gt; For &lt;code&gt;document&lt;/code&gt;, the prompt is &lt;i&gt;"Represent the document for retrieval: ".&lt;/i&gt; &lt;/li&gt;<br/>
        ///   &lt;/ul&gt; <br/>
        /// &lt;ul&gt;<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="truncation">
        /// Whether to truncate the inputs to fit within the context length. Defaults to `true`. &lt;ul&gt;  &lt;li&gt; If `true`, an over-length input will be truncated to fit within the context length before being vectorized by the embedding model. If the truncation happens in the middle of an image, the entire image will be discarded. &lt;/li&gt; &lt;li&gt; If `false`, an error will be raised if any input exceeds the context length. &lt;/li&gt;  &lt;/ul&gt;<br/>
        /// Default Value: true
        /// </param>
        /// <param name="outputEncoding">
        /// Format in which the embeddings are encoded. Defaults to `null`. &lt;ul&gt; &lt;li&gt; If `null`, the embeddings are represented as a list of floating-point numbers. &lt;/li&gt;  &lt;li&gt; If `base64`, the embeddings are represented as a Base64-encoded NumPy array of single-precision floats. &lt;/li&gt;  &lt;/ul&gt;<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.MultimodalEmbeddingsApiResponse> MultimodalEmbeddingsApiAsync(
            byte[] inputs,
            string model,
            global::G.MultimodalEmbeddingsApiRequestInputType? inputType = default,
            bool? truncation = default,
            global::G.MultimodalEmbeddingsApiRequestOutputEncoding? outputEncoding = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.MultimodalEmbeddingsApiRequest
            {
                Inputs = inputs,
                Model = model,
                InputType = inputType,
                Truncation = truncation,
                OutputEncoding = outputEncoding,
            };

            return await MultimodalEmbeddingsApiAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}