//HintName: G.IApi.EmbeddingsApi.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Text embedding models<br/>
        /// Voyage text embedding endpoint receives as input a string (or a list of strings) and other arguments such as the preferred model name, and returns a response containing a list of embeddings.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbeddingsApiResponse> EmbeddingsApiAsync(

            global::G.EmbeddingsApiRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbeddingsApiResponse> EmbeddingsApiAsync(
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>> input,
            string model,
            global::G.EmbeddingsApiRequestInputType? inputType = default,
            bool? truncation = default,
            int? outputDimension = default,
            global::G.EmbeddingsApiRequestOutputDtype? outputDtype = default,
            global::G.EmbeddingsApiRequestEncodingFormat? encodingFormat = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}