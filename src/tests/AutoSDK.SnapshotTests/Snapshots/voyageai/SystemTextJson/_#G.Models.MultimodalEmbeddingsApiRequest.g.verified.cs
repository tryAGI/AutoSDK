//HintName: G.Models.MultimodalEmbeddingsApiRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultimodalEmbeddingsApiRequest
    {
        /// <summary>
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
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Inputs { get; set; }

        /// <summary>
        /// Name of the model. Currently, the only supported model is `voyage-multimodal-3`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Type of the input. Defaults to `null`. Other options: `query`, `document`. &lt;ul&gt; &lt;li&gt; When `input_type` is `null`, the embedding model directly converts the `inputs` into numerical vectors. For retrieval/search purposes, where a "query", which can be text or image in this case, is used to search for relevant information among a collection of data referred to as "documents," we recommend specifying whether your `inputs` are intended as queries or documents by setting `input_type` to `query` or `document`, respectively. In these cases, Voyage automatically prepends a prompt to your `inputs` before vectorizing them, creating vectors more tailored for retrieval/search tasks. Since inputs can be multimodal, "queries" and "documents" can be text, images, or an interleaving of both modalities. Embeddings generated with and without the `input_type` argument are compatible. &lt;/li&gt; &lt;li&gt; For transparency, the following prompts are prepended to your input. &lt;/li&gt;<br/>
        ///   &lt;ul&gt;<br/>
        ///     &lt;li&gt; For &lt;code&gt;query&lt;/code&gt;, the prompt is &lt;i&gt;"Represent the query for retrieving supporting documents: ".&lt;/i&gt; &lt;/li&gt;<br/>
        ///     &lt;li&gt; For &lt;code&gt;document&lt;/code&gt;, the prompt is &lt;i&gt;"Represent the document for retrieval: ".&lt;/i&gt; &lt;/li&gt;<br/>
        ///   &lt;/ul&gt; <br/>
        /// &lt;ul&gt;<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MultimodalEmbeddingsApiRequestInputTypeJsonConverter))]
        public global::G.MultimodalEmbeddingsApiRequestInputType? InputType { get; set; }

        /// <summary>
        /// Whether to truncate the inputs to fit within the context length. Defaults to `true`. &lt;ul&gt;  &lt;li&gt; If `true`, an over-length input will be truncated to fit within the context length before being vectorized by the embedding model. If the truncation happens in the middle of an image, the entire image will be discarded. &lt;/li&gt; &lt;li&gt; If `false`, an error will be raised if any input exceeds the context length. &lt;/li&gt;  &lt;/ul&gt;<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation")]
        public bool? Truncation { get; set; }

        /// <summary>
        /// Format in which the embeddings are encoded. Defaults to `null`. &lt;ul&gt; &lt;li&gt; If `null`, the embeddings are represented as a list of floating-point numbers. &lt;/li&gt;  &lt;li&gt; If `base64`, the embeddings are represented as a Base64-encoded NumPy array of single-precision floats. &lt;/li&gt;  &lt;/ul&gt;<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MultimodalEmbeddingsApiRequestOutputEncodingJsonConverter))]
        public global::G.MultimodalEmbeddingsApiRequestOutputEncoding? OutputEncoding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalEmbeddingsApiRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultimodalEmbeddingsApiRequest(
            byte[] inputs,
            string model,
            global::G.MultimodalEmbeddingsApiRequestInputType? inputType,
            bool? truncation,
            global::G.MultimodalEmbeddingsApiRequestOutputEncoding? outputEncoding)
        {
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.InputType = inputType;
            this.Truncation = truncation;
            this.OutputEncoding = outputEncoding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalEmbeddingsApiRequest" /> class.
        /// </summary>
        public MultimodalEmbeddingsApiRequest()
        {
        }
    }
}