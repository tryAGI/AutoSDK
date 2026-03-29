//HintName: G.Models.MultipleEncodingsEmbeddingItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultipleEncodingsEmbeddingItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("float")]
        public global::System.Collections.Generic.IList<double>? Float { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("int8")]
        public global::System.Collections.Generic.IList<int>? Int8 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uint8")]
        public global::System.Collections.Generic.IList<int>? Uint8 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("binary")]
        public global::System.Collections.Generic.IList<int>? Binary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ubinary")]
        public global::System.Collections.Generic.IList<int>? Ubinary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base64")]
        public string? Base64 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipleEncodingsEmbeddingItem" /> class.
        /// </summary>
        /// <param name="float"></param>
        /// <param name="int8"></param>
        /// <param name="uint8"></param>
        /// <param name="binary"></param>
        /// <param name="ubinary"></param>
        /// <param name="base64"></param>
        public MultipleEncodingsEmbeddingItem(
            global::System.Collections.Generic.IList<double>? @float,
            global::System.Collections.Generic.IList<int>? int8,
            global::System.Collections.Generic.IList<int>? uint8,
            global::System.Collections.Generic.IList<int>? binary,
            global::System.Collections.Generic.IList<int>? ubinary,
            string? base64)
        {
            this.Float = @float;
            this.Int8 = int8;
            this.Uint8 = uint8;
            this.Binary = binary;
            this.Ubinary = ubinary;
            this.Base64 = base64;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipleEncodingsEmbeddingItem" /> class.
        /// </summary>
        public MultipleEncodingsEmbeddingItem()
        {
        }
    }
}