//HintName: G.Models.EmbedByTypeResponseEmbeddings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object with different embedding types. The length of each embedding type array will be the same as the length of the original `texts` array.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class EmbedByTypeResponseEmbeddings
    {
        /// <summary>
        /// An array of float embeddings.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("float")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Float { get; set; }

        /// <summary>
        /// An array of signed int8 embeddings. Each value is between -128 and 127.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("int8")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Int8 { get; set; }

        /// <summary>
        /// An array of unsigned int8 embeddings. Each value is between 0 and 255.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uint8")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Uint8 { get; set; }

        /// <summary>
        /// An array of packed signed binary embeddings. The length of each binary embedding is 1/8 the length of the float embeddings of the provided model. Each value is between -128 and 127.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("binary")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Binary { get; set; }

        /// <summary>
        /// An array of packed unsigned binary embeddings. The length of each binary embedding is 1/8 the length of the float embeddings of the provided model. Each value is between 0 and 255.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ubinary")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Ubinary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedByTypeResponseEmbeddings" /> class.
        /// </summary>
        /// <param name="float">
        /// An array of float embeddings.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="int8">
        /// An array of signed int8 embeddings. Each value is between -128 and 127.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="uint8">
        /// An array of unsigned int8 embeddings. Each value is between 0 and 255.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="binary">
        /// An array of packed signed binary embeddings. The length of each binary embedding is 1/8 the length of the float embeddings of the provided model. Each value is between -128 and 127.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="ubinary">
        /// An array of packed unsigned binary embeddings. The length of each binary embedding is 1/8 the length of the float embeddings of the provided model. Each value is between 0 and 255.
        /// </param>
        public EmbedByTypeResponseEmbeddings(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? @float,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? int8,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? uint8,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? binary,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? ubinary)
        {
            this.Float = @float;
            this.Int8 = int8;
            this.Uint8 = uint8;
            this.Binary = binary;
            this.Ubinary = ubinary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedByTypeResponseEmbeddings" /> class.
        /// </summary>
        public EmbedByTypeResponseEmbeddings()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.EmbedByTypeResponseEmbeddings? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.EmbedByTypeResponseEmbeddings>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.EmbedByTypeResponseEmbeddings?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.EmbedByTypeResponseEmbeddings?>(serializer.Deserialize<global::G.EmbedByTypeResponseEmbeddings>(jsonReader));
        }

    }
}