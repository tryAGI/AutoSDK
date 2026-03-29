//HintName: G.Models.EmbeddingsApiRequestInputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the input text. Defaults to `null`. Other options: `query`, `document`. &lt;ul&gt; &lt;li&gt; When `input_type` is `null`, the embedding model directly converts the inputs (`texts`) into numerical vectors. For retrieval/search purposes, where a "query" is used to search for relevant information among a collection of data referred to as "documents," we recommend specifying whether your inputs (`texts`) are intended as queries or documents by setting `input_type` to `query` or `document`, respectively. In these cases, Voyage automatically prepends a prompt to your `inputs` before vectorizing them, creating vectors more tailored for retrieval/search tasks. Embeddings generated with and without the `input_type` argument are compatible. &lt;/li&gt; &lt;li&gt; For transparency, the following prompts are prepended to your input. &lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt; For &lt;code&gt;query&lt;/code&gt;, the prompt is &lt;i&gt;"Represent the query for retrieving supporting documents: ".&lt;/i&gt; &lt;/li&gt;<br/>
    ///     &lt;li&gt; For &lt;code&gt;document&lt;/code&gt;, the prompt is &lt;i&gt;"Represent the document for retrieval: ".&lt;/i&gt; &lt;/li&gt;<br/>
    ///   &lt;/ul&gt; <br/>
    /// &lt;ul&gt; &lt;ul&gt;<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EmbeddingsApiRequestInputType
    {
        /// <summary>
        /// `query`, `document`. &lt;ul&gt; &lt;li&gt; When `input_type` is `null`, the embedding model directly converts the inputs (`texts`) into numerical vectors. For retrieval/search purposes, where a "query" is used to search for relevant information among a collection of data referred to as "documents," we recommend specifying whether your inputs (`texts`) are intended as queries or documents by setting `input_type` to `query` or `document`, respectively. In these cases, Voyage automatically prepends a prompt to your `inputs` before vectorizing them, creating vectors more tailored for retrieval/search tasks. Embeddings generated with and without the `input_type` argument are compatible. &lt;/li&gt; &lt;li&gt; For transparency, the following prompts are prepended to your input. &lt;/li&gt;
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="document")]
        Document,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464")]
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
        /// <summary>
        /// `query`, `document`. &lt;ul&gt; &lt;li&gt; When `input_type` is `null`, the embedding model directly converts the inputs (`texts`) into numerical vectors. For retrieval/search purposes, where a "query" is used to search for relevant information among a collection of data referred to as "documents," we recommend specifying whether your inputs (`texts`) are intended as queries or documents by setting `input_type` to `query` or `document`, respectively. In these cases, Voyage automatically prepends a prompt to your `inputs` before vectorizing them, creating vectors more tailored for retrieval/search tasks. Embeddings generated with and without the `input_type` argument are compatible. &lt;/li&gt; &lt;li&gt; For transparency, the following prompts are prepended to your input. &lt;/li&gt;
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="query")]
        Query,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingsApiRequestInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsApiRequestInputType value)
        {
            return value switch
            {
                EmbeddingsApiRequestInputType.Document => "document",
                EmbeddingsApiRequestInputType.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                EmbeddingsApiRequestInputType.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsApiRequestInputType? ToEnum(string value)
        {
            return value switch
            {
                "document" => EmbeddingsApiRequestInputType.Document,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => EmbeddingsApiRequestInputType.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "query" => EmbeddingsApiRequestInputType.Query,
                _ => null,
            };
        }
    }
}