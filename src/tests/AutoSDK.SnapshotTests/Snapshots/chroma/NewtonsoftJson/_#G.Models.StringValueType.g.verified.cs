//HintName: G.Models.StringValueType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// String value type index configurations
    /// </summary>
    public sealed partial class StringValueType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fts_index")]
        public global::G.OneOf<object, global::G.FtsIndexType>? FtsIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("string_inverted_index")]
        public global::G.OneOf<object, global::G.StringInvertedIndexType>? StringInvertedIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StringValueType" /> class.
        /// </summary>
        /// <param name="ftsIndex"></param>
        /// <param name="stringInvertedIndex"></param>
        public StringValueType(
            global::G.OneOf<object, global::G.FtsIndexType>? ftsIndex,
            global::G.OneOf<object, global::G.StringInvertedIndexType>? stringInvertedIndex)
        {
            this.FtsIndex = ftsIndex;
            this.StringInvertedIndex = stringInvertedIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringValueType" /> class.
        /// </summary>
        public StringValueType()
        {
        }
    }
}