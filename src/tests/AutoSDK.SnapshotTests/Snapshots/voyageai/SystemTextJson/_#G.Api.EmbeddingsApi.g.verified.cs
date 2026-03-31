//HintName: G.Api.EmbeddingsApi.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareEmbeddingsApiArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.EmbeddingsApiRequest request);
        partial void PrepareEmbeddingsApiRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.EmbeddingsApiRequest request);
        partial void ProcessEmbeddingsApiResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEmbeddingsApiResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Text embedding models<br/>
        /// Voyage text embedding endpoint receives as input a string (or a list of strings) and other arguments such as the preferred model name, and returns a response containing a list of embeddings.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EmbeddingsApiResponse> EmbeddingsApiAsync(

            global::G.EmbeddingsApiRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareEmbeddingsApiArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/embeddings",
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareEmbeddingsApiRequest(
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
            ProcessEmbeddingsApiResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Client error  <p> This indicates an issue with the request format or frequency. Please see our  [Error Codes](https://docs.voyageai.com/docs/error-codes) guide. </p> 
            if ((int)__response.StatusCode >= 400 && (int)__response.StatusCode <= 499)
            {
                string? __content_4XX = null;
                global::System.Exception? __exception_4XX = null;
                global::G.EmbeddingsApiResponse2? __value_4XX = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_4XX = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_4XX = global::G.EmbeddingsApiResponse2.FromJson(__content_4XX, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_4XX = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_4XX = global::G.EmbeddingsApiResponse2.FromJson(__content_4XX, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_4XX = __ex;
                }

                throw new global::G.ApiException<global::G.EmbeddingsApiResponse2>(
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
                ProcessEmbeddingsApiResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.EmbeddingsApiResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.EmbeddingsApiResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Text embedding models<br/>
        /// Voyage text embedding endpoint receives as input a string (or a list of strings) and other arguments such as the preferred model name, and returns a response containing a list of embeddings.
        /// </summary>
        /// <param name="input">
        /// A single text string, or a list of texts as a list of strings, such as `["I like cats", "I also like dogs"]`. Currently, we have two constraints on the list: &lt;ul&gt;  &lt;li&gt; The maximum length of the list is 128. &lt;/li&gt;  &lt;li&gt; The total number of tokens in the list is at most 1M for `voyage-3-lite`; 320K for `voyage-3` and `voyage-2`; and 120K for `voyage-3-large`, `voyage-code-3`, `voyage-large-2-instruct`, `voyage-finance-2`, `voyage-multilingual-2`, `voyage-law-2`, and `voyage-large-2`. &lt;/li&gt; &lt;ul&gt;
        /// </param>
        /// <param name="model">
        /// Name of the model. Recommended options: `voyage-3-large`, `voyage-3`, `voyage-3-lite`, `voyage-code-3`, `voyage-finance-2`, `voyage-law-2`.
        /// </param>
        /// <param name="inputType">
        /// Type of the input text. Defaults to `null`. Other options: `query`, `document`. &lt;ul&gt; &lt;li&gt; When `input_type` is `null`, the embedding model directly converts the inputs (`texts`) into numerical vectors. For retrieval/search purposes, where a "query" is used to search for relevant information among a collection of data referred to as "documents," we recommend specifying whether your inputs (`texts`) are intended as queries or documents by setting `input_type` to `query` or `document`, respectively. In these cases, Voyage automatically prepends a prompt to your `inputs` before vectorizing them, creating vectors more tailored for retrieval/search tasks. Embeddings generated with and without the `input_type` argument are compatible. &lt;/li&gt; &lt;li&gt; For transparency, the following prompts are prepended to your input. &lt;/li&gt;<br/>
        ///   &lt;ul&gt;<br/>
        ///     &lt;li&gt; For &lt;code&gt;query&lt;/code&gt;, the prompt is &lt;i&gt;"Represent the query for retrieving supporting documents: ".&lt;/i&gt; &lt;/li&gt;<br/>
        ///     &lt;li&gt; For &lt;code&gt;document&lt;/code&gt;, the prompt is &lt;i&gt;"Represent the document for retrieval: ".&lt;/i&gt; &lt;/li&gt;<br/>
        ///   &lt;/ul&gt; <br/>
        /// &lt;ul&gt; &lt;ul&gt;<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="truncation">
        /// Whether to truncate the input texts to fit within the context length. Defaults to `true`. &lt;ul&gt;  &lt;li&gt; If `true`, an over-length input texts will be truncated to fit within the context length, before vectorized by the embedding model. &lt;/li&gt;  &lt;li&gt; If `false`, an error will be raised if any given text exceeds the context length. &lt;/li&gt;  &lt;/ul&gt;<br/>
        /// Default Value: true
        /// </param>
        /// <param name="outputDimension">
        /// The number of dimensions for resulting output embeddings. Defaults to `null`. &lt;ul&gt; &lt;li&gt; Most models only support a single default dimension, used when `output_dimension` is set to `null` (see output embedding dimensions &lt;a href="https://docs.voyageai.com/docs/embeddings" target="_blank"&gt;here&lt;/a&gt;). &lt;/li&gt; &lt;li&gt; `voyage-3-large` and `voyage-code-3` support the following `output_dimension` values: 2048, 1024 (default), 512, and 256. &lt;/li&gt; &lt;/ul&gt;<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="outputDtype">
        /// The data type for the embeddings to be returned. Defaults to `float`. Other options: `int8`, `uint8`, `binary`, `ubinary`. `float` is supported for all models. `int8`, `uint8`, `binary`, and `ubinary` are supported by `voyage-3-large` and `voyage-code-3`. Please see our &lt;a href="https://docs.voyageai.com/docs/flexible-dimensions-and-quantization#quantization" target="_blank"&gt;guide&lt;/a&gt; for more details about output data types. &lt;ul&gt; &lt;li&gt; `float`: Each returned embedding is a list of 32-bit (4-byte) &lt;a href="https://en.wikipedia.org/wiki/Single-precision_floating-point_format" target="_blank"&gt;single-precision floating-point&lt;/a&gt; numbers. This is the default and provides the highest precision / retrieval accuracy. &lt;/li&gt; &lt;li&gt; `int8` and `uint8`: Each returned embedding is a list of 8-bit (1-byte) integers ranging from -128 to 127 and 0 to 255, respectively. &lt;/li&gt; &lt;li&gt; `binary` and `ubinary`: Each returned embedding is a list of 8-bit integers that represent bit-packed, quantized single-bit embedding values: `int8` for `binary` and `uint8` for `ubinary`. The length of the returned list of integers is 1/8 of `output_dimension` (which is the actual dimension of the embedding). The `binary` type uses the offset binary method. Please refer to our guide for details on &lt;a href="https://docs.voyageai.com/docs/flexible-dimensions-and-quantization#offset-binary" target="_blank"&gt;offset binary&lt;/a&gt; and &lt;a href="https://docs.voyageai.com/docs/flexible-dimensions-and-quantization#quantization" target="_blank"&gt;binary embeddings&lt;/a&gt;.  &lt;/ul&gt;<br/>
        /// Default Value: float
        /// </param>
        /// <param name="encodingFormat">
        /// Format in which the embeddings are encoded. Defaults to `null`. Other options: `base64`. &lt;ul&gt; &lt;li&gt; If `null`, each embedding is an array of float numbers when `output_dtype` is set to `float` and as an array of integers for all other values of `output_dtype` (`int8`, `uint8`, `binary`, and `ubinary`). &lt;li&gt; If `base64`, the embeddings are represented as a &lt;a href="https://docs.python.org/3/library/base64.html" target="_blank"&gt;Base64-encoded&lt;/a&gt; NumPy array of: &lt;/li&gt;<br/>
        ///   &lt;ul&gt;<br/>
        ///     &lt;li&gt; Floating-point numbers (&lt;a href="https://numpy.org/doc/2.1/user/basics.types.html#numerical-data-types" target="_blank"&gt;numpy.float32&lt;/a&gt;) for &lt;code&gt;output_dtype&lt;/code&gt; set to &lt;code&gt;float&lt;/code&gt;. &lt;/li&gt;<br/>
        ///     &lt;li&gt; Signed integers (&lt;a href="https://numpy.org/doc/2.1/user/basics.types.html#numerical-data-types" target="_blank"&gt;numpy.int8&lt;/a&gt;) for &lt;code&gt;output_dtype&lt;/code&gt; set to &lt;code&gt;int8&lt;/code&gt; or &lt;code&gt;binary&lt;/code&gt;. &lt;/li&gt;<br/>
        ///     &lt;li&gt; Unsigned integers (&lt;a href="https://numpy.org/doc/2.1/user/basics.types.html#numerical-data-types" target="_blank"&gt;numpy.uint8&lt;/a&gt;) for &lt;code&gt;output_dtype&lt;/code&gt; set to &lt;code&gt;uint8&lt;/code&gt; or &lt;code&gt;ubinary&lt;/code&gt;. &lt;/li&gt;<br/>
        ///   &lt;/ul&gt; <br/>
        /// &lt;/ul&gt;<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EmbeddingsApiResponse> EmbeddingsApiAsync(
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>> input,
            string model,
            global::G.EmbeddingsApiRequestInputType? inputType = default,
            bool? truncation = default,
            int? outputDimension = default,
            global::G.EmbeddingsApiRequestOutputDtype? outputDtype = default,
            global::G.EmbeddingsApiRequestEncodingFormat? encodingFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.EmbeddingsApiRequest
            {
                Input = input,
                Model = model,
                InputType = inputType,
                Truncation = truncation,
                OutputDimension = outputDimension,
                OutputDtype = outputDtype,
                EncodingFormat = encodingFormat,
            };

            return await EmbeddingsApiAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}