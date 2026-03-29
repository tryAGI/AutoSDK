//HintName: G.Models.EmbeddingsApiRequestOutputDtype.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The data type for the embeddings to be returned. Defaults to `float`. Other options: `int8`, `uint8`, `binary`, `ubinary`. `float` is supported for all models. `int8`, `uint8`, `binary`, and `ubinary` are supported by `voyage-3-large` and `voyage-code-3`. Please see our &lt;a href="https://docs.voyageai.com/docs/flexible-dimensions-and-quantization#quantization" target="_blank"&gt;guide&lt;/a&gt; for more details about output data types. &lt;ul&gt; &lt;li&gt; `float`: Each returned embedding is a list of 32-bit (4-byte) &lt;a href="https://en.wikipedia.org/wiki/Single-precision_floating-point_format" target="_blank"&gt;single-precision floating-point&lt;/a&gt; numbers. This is the default and provides the highest precision / retrieval accuracy. &lt;/li&gt; &lt;li&gt; `int8` and `uint8`: Each returned embedding is a list of 8-bit (1-byte) integers ranging from -128 to 127 and 0 to 255, respectively. &lt;/li&gt; &lt;li&gt; `binary` and `ubinary`: Each returned embedding is a list of 8-bit integers that represent bit-packed, quantized single-bit embedding values: `int8` for `binary` and `uint8` for `ubinary`. The length of the returned list of integers is 1/8 of `output_dimension` (which is the actual dimension of the embedding). The `binary` type uses the offset binary method. Please refer to our guide for details on &lt;a href="https://docs.voyageai.com/docs/flexible-dimensions-and-quantization#offset-binary" target="_blank"&gt;offset binary&lt;/a&gt; and &lt;a href="https://docs.voyageai.com/docs/flexible-dimensions-and-quantization#quantization" target="_blank"&gt;binary embeddings&lt;/a&gt;.  &lt;/ul&gt;<br/>
    /// Default Value: float
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EmbeddingsApiRequestOutputDtype
    {
        /// <summary>
        /// `int8`, `uint8`, `binary`, `ubinary`. `float` is supported for all models. `int8`, `uint8`, `binary`, and `ubinary` are supported by `voyage-3-large` and `voyage-code-3`. Please see our &lt;a href="https://docs.voyageai.com/docs/flexible-dimensions-and-quantization#quantization" target="_blank"&gt;guide&lt;/a&gt; for more details about output data types. &lt;ul&gt; &lt;li&gt; `float`: Each returned embedding is a list of 32-bit (4-byte) &lt;a href="https://en.wikipedia.org/wiki/Single-precision_floating-point_format" target="_blank"&gt;single-precision floating-point&lt;/a&gt; numbers. This is the default and provides the highest precision / retrieval accuracy. &lt;/li&gt; &lt;li&gt; `int8` and `uint8`: Each returned embedding is a list of 8-bit (1-byte) integers ranging from -128 to 127 and 0 to 255, respectively. &lt;/li&gt; &lt;li&gt; `binary` and `ubinary`: Each returned embedding is a list of 8-bit integers that represent bit-packed, quantized single-bit embedding values: `int8` for `binary` and `uint8` for `ubinary`. The length of the returned list of integers is 1/8 of `output_dimension` (which is the actual dimension of the embedding). The `binary` type uses the offset binary method. Please refer to our guide for details on &lt;a href="https://docs.voyageai.com/docs/flexible-dimensions-and-quantization#offset-binary" target="_blank"&gt;offset binary&lt;/a&gt; and &lt;a href="https://docs.voyageai.com/docs/flexible-dimensions-and-quantization#quantization" target="_blank"&gt;binary embeddings&lt;/a&gt;.  &lt;/ul&gt;
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="binary")]
        Binary,
        /// <summary>
        /// `int8`, `uint8`, `binary`, `ubinary`. `float` is supported for all models. `int8`, `uint8`, `binary`, and `ubinary` are supported by `voyage-3-large` and `voyage-code-3`. Please see our &lt;a href="https://docs.voyageai.com/docs/flexible-dimensions-and-quantization#quantization" target="_blank"&gt;guide&lt;/a&gt; for more details about output data types. &lt;ul&gt; &lt;li&gt; `float`: Each returned embedding is a list of 32-bit (4-byte) &lt;a href="https://en.wikipedia.org/wiki/Single-precision_floating-point_format" target="_blank"&gt;single-precision floating-point&lt;/a&gt; numbers. This is the default and provides the highest precision / retrieval accuracy. &lt;/li&gt; &lt;li&gt; `int8` and `uint8`: Each returned embedding is a list of 8-bit (1-byte) integers ranging from -128 to 127 and 0 to 255, respectively. &lt;/li&gt; &lt;li&gt; `binary` and `ubinary`: Each returned embedding is a list of 8-bit integers that represent bit-packed, quantized single-bit embedding values: `int8` for `binary` and `uint8` for `ubinary`. The length of the returned list of integers is 1/8 of `output_dimension` (which is the actual dimension of the embedding). The `binary` type uses the offset binary method. Please refer to our guide for details on &lt;a href="https://docs.voyageai.com/docs/flexible-dimensions-and-quantization#offset-binary" target="_blank"&gt;offset binary&lt;/a&gt; and &lt;a href="https://docs.voyageai.com/docs/flexible-dimensions-and-quantization#quantization" target="_blank"&gt;binary embeddings&lt;/a&gt;.  &lt;/ul&gt;
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="float")]
        Float,
        /// <summary>
        /// `int8`, `uint8`, `binary`, `ubinary`. `float` is supported for all models. `int8`, `uint8`, `binary`, and `ubinary` are supported by `voyage-3-large` and `voyage-code-3`. Please see our &lt;a href="https://docs.voyageai.com/docs/flexible-dimensions-and-quantization#quantization" target="_blank"&gt;guide&lt;/a&gt; for more details about output data types. &lt;ul&gt; &lt;li&gt; `float`: Each returned embedding is a list of 32-bit (4-byte) &lt;a href="https://en.wikipedia.org/wiki/Single-precision_floating-point_format" target="_blank"&gt;single-precision floating-point&lt;/a&gt; numbers. This is the default and provides the highest precision / retrieval accuracy. &lt;/li&gt; &lt;li&gt; `int8` and `uint8`: Each returned embedding is a list of 8-bit (1-byte) integers ranging from -128 to 127 and 0 to 255, respectively. &lt;/li&gt; &lt;li&gt; `binary` and `ubinary`: Each returned embedding is a list of 8-bit integers that represent bit-packed, quantized single-bit embedding values: `int8` for `binary` and `uint8` for `ubinary`. The length of the returned list of integers is 1/8 of `output_dimension` (which is the actual dimension of the embedding). The `binary` type uses the offset binary method. Please refer to our guide for details on &lt;a href="https://docs.voyageai.com/docs/flexible-dimensions-and-quantization#offset-binary" target="_blank"&gt;offset binary&lt;/a&gt; and &lt;a href="https://docs.voyageai.com/docs/flexible-dimensions-and-quantization#quantization" target="_blank"&gt;binary embeddings&lt;/a&gt;.  &lt;/ul&gt;
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="int8")]
        Int8,
        /// <summary>
        /// `int8`, `uint8`, `binary`, `ubinary`. `float` is supported for all models. `int8`, `uint8`, `binary`, and `ubinary` are supported by `voyage-3-large` and `voyage-code-3`. Please see our &lt;a href="https://docs.voyageai.com/docs/flexible-dimensions-and-quantization#quantization" target="_blank"&gt;guide&lt;/a&gt; for more details about output data types. &lt;ul&gt; &lt;li&gt; `float`: Each returned embedding is a list of 32-bit (4-byte) &lt;a href="https://en.wikipedia.org/wiki/Single-precision_floating-point_format" target="_blank"&gt;single-precision floating-point&lt;/a&gt; numbers. This is the default and provides the highest precision / retrieval accuracy. &lt;/li&gt; &lt;li&gt; `int8` and `uint8`: Each returned embedding is a list of 8-bit (1-byte) integers ranging from -128 to 127 and 0 to 255, respectively. &lt;/li&gt; &lt;li&gt; `binary` and `ubinary`: Each returned embedding is a list of 8-bit integers that represent bit-packed, quantized single-bit embedding values: `int8` for `binary` and `uint8` for `ubinary`. The length of the returned list of integers is 1/8 of `output_dimension` (which is the actual dimension of the embedding). The `binary` type uses the offset binary method. Please refer to our guide for details on &lt;a href="https://docs.voyageai.com/docs/flexible-dimensions-and-quantization#offset-binary" target="_blank"&gt;offset binary&lt;/a&gt; and &lt;a href="https://docs.voyageai.com/docs/flexible-dimensions-and-quantization#quantization" target="_blank"&gt;binary embeddings&lt;/a&gt;.  &lt;/ul&gt;
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ubinary")]
        Ubinary,
        /// <summary>
        /// `int8`, `uint8`, `binary`, `ubinary`. `float` is supported for all models. `int8`, `uint8`, `binary`, and `ubinary` are supported by `voyage-3-large` and `voyage-code-3`. Please see our &lt;a href="https://docs.voyageai.com/docs/flexible-dimensions-and-quantization#quantization" target="_blank"&gt;guide&lt;/a&gt; for more details about output data types. &lt;ul&gt; &lt;li&gt; `float`: Each returned embedding is a list of 32-bit (4-byte) &lt;a href="https://en.wikipedia.org/wiki/Single-precision_floating-point_format" target="_blank"&gt;single-precision floating-point&lt;/a&gt; numbers. This is the default and provides the highest precision / retrieval accuracy. &lt;/li&gt; &lt;li&gt; `int8` and `uint8`: Each returned embedding is a list of 8-bit (1-byte) integers ranging from -128 to 127 and 0 to 255, respectively. &lt;/li&gt; &lt;li&gt; `binary` and `ubinary`: Each returned embedding is a list of 8-bit integers that represent bit-packed, quantized single-bit embedding values: `int8` for `binary` and `uint8` for `ubinary`. The length of the returned list of integers is 1/8 of `output_dimension` (which is the actual dimension of the embedding). The `binary` type uses the offset binary method. Please refer to our guide for details on &lt;a href="https://docs.voyageai.com/docs/flexible-dimensions-and-quantization#offset-binary" target="_blank"&gt;offset binary&lt;/a&gt; and &lt;a href="https://docs.voyageai.com/docs/flexible-dimensions-and-quantization#quantization" target="_blank"&gt;binary embeddings&lt;/a&gt;.  &lt;/ul&gt;
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uint8")]
        Uint8,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingsApiRequestOutputDtypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsApiRequestOutputDtype value)
        {
            return value switch
            {
                EmbeddingsApiRequestOutputDtype.Binary => "binary",
                EmbeddingsApiRequestOutputDtype.Float => "float",
                EmbeddingsApiRequestOutputDtype.Int8 => "int8",
                EmbeddingsApiRequestOutputDtype.Ubinary => "ubinary",
                EmbeddingsApiRequestOutputDtype.Uint8 => "uint8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsApiRequestOutputDtype? ToEnum(string value)
        {
            return value switch
            {
                "binary" => EmbeddingsApiRequestOutputDtype.Binary,
                "float" => EmbeddingsApiRequestOutputDtype.Float,
                "int8" => EmbeddingsApiRequestOutputDtype.Int8,
                "ubinary" => EmbeddingsApiRequestOutputDtype.Ubinary,
                "uint8" => EmbeddingsApiRequestOutputDtype.Uint8,
                _ => null,
            };
        }
    }
}