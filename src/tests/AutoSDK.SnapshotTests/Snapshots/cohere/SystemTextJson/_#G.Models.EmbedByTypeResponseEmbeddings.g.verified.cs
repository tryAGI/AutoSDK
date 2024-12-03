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
        [global::System.Text.Json.Serialization.JsonPropertyName("float")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Float { get; set; }

        /// <summary>
        /// An array of signed int8 embeddings. Each value is between -128 and 127.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("int8")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Int8 { get; set; }

        /// <summary>
        /// An array of unsigned int8 embeddings. Each value is between 0 and 255.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uint8")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Uint8 { get; set; }

        /// <summary>
        /// An array of packed signed binary embeddings. The length of each binary embedding is 1/8 the length of the float embeddings of the provided model. Each value is between -128 and 127.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("binary")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Binary { get; set; }

        /// <summary>
        /// An array of packed unsigned binary embeddings. The length of each binary embedding is 1/8 the length of the float embeddings of the provided model. Each value is between 0 and 255.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ubinary")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Ubinary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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
    }
}