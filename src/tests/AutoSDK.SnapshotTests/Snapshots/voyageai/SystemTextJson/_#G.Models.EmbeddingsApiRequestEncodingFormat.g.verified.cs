//HintName: G.Models.EmbeddingsApiRequestEncodingFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Format in which the embeddings are encoded. Defaults to `null`. Other options: `base64`. &lt;ul&gt; &lt;li&gt; If `null`, each embedding is an array of float numbers when `output_dtype` is set to `float` and as an array of integers for all other values of `output_dtype` (`int8`, `uint8`, `binary`, and `ubinary`). &lt;li&gt; If `base64`, the embeddings are represented as a &lt;a href="https://docs.python.org/3/library/base64.html" target="_blank"&gt;Base64-encoded&lt;/a&gt; NumPy array of: &lt;/li&gt;<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt; Floating-point numbers (&lt;a href="https://numpy.org/doc/2.1/user/basics.types.html#numerical-data-types" target="_blank"&gt;numpy.float32&lt;/a&gt;) for &lt;code&gt;output_dtype&lt;/code&gt; set to &lt;code&gt;float&lt;/code&gt;. &lt;/li&gt;<br/>
    ///     &lt;li&gt; Signed integers (&lt;a href="https://numpy.org/doc/2.1/user/basics.types.html#numerical-data-types" target="_blank"&gt;numpy.int8&lt;/a&gt;) for &lt;code&gt;output_dtype&lt;/code&gt; set to &lt;code&gt;int8&lt;/code&gt; or &lt;code&gt;binary&lt;/code&gt;. &lt;/li&gt;<br/>
    ///     &lt;li&gt; Unsigned integers (&lt;a href="https://numpy.org/doc/2.1/user/basics.types.html#numerical-data-types" target="_blank"&gt;numpy.uint8&lt;/a&gt;) for &lt;code&gt;output_dtype&lt;/code&gt; set to &lt;code&gt;uint8&lt;/code&gt; or &lt;code&gt;ubinary&lt;/code&gt;. &lt;/li&gt;<br/>
    ///   &lt;/ul&gt; <br/>
    /// &lt;/ul&gt;<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public enum EmbeddingsApiRequestEncodingFormat
    {
        /// <summary>
        /// `base64`. &lt;ul&gt; &lt;li&gt; If `null`, each embedding is an array of float numbers when `output_dtype` is set to `float` and as an array of integers for all other values of `output_dtype` (`int8`, `uint8`, `binary`, and `ubinary`). &lt;li&gt; If `base64`, the embeddings are represented as a &lt;a href="https://docs.python.org/3/library/base64.html" target="_blank"&gt;Base64-encoded&lt;/a&gt; NumPy array of: &lt;/li&gt;
        /// </summary>
        Base64,
        /// <summary>
        /// 
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingsApiRequestEncodingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsApiRequestEncodingFormat value)
        {
            return value switch
            {
                EmbeddingsApiRequestEncodingFormat.Base64 => "base64",
                EmbeddingsApiRequestEncodingFormat.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsApiRequestEncodingFormat? ToEnum(string value)
        {
            return value switch
            {
                "base64" => EmbeddingsApiRequestEncodingFormat.Base64,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => EmbeddingsApiRequestEncodingFormat.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                _ => null,
            };
        }
    }
}