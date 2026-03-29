//HintName: G.Models.FloatValueType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Float value type index configurations
    /// </summary>
    public sealed partial class FloatValueType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("float_inverted_index")]
        public global::G.OneOf<object, global::G.FloatInvertedIndexType>? FloatInvertedIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FloatValueType" /> class.
        /// </summary>
        /// <param name="floatInvertedIndex"></param>
        public FloatValueType(
            global::G.OneOf<object, global::G.FloatInvertedIndexType>? floatInvertedIndex)
        {
            this.FloatInvertedIndex = floatInvertedIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FloatValueType" /> class.
        /// </summary>
        public FloatValueType()
        {
        }
    }
}