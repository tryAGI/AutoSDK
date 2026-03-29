//HintName: G.Models.BoolValueType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Boolean value type index configurations
    /// </summary>
    public sealed partial class BoolValueType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bool_inverted_index")]
        public global::G.OneOf<object, global::G.BoolInvertedIndexType>? BoolInvertedIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BoolValueType" /> class.
        /// </summary>
        /// <param name="boolInvertedIndex"></param>
        public BoolValueType(
            global::G.OneOf<object, global::G.BoolInvertedIndexType>? boolInvertedIndex)
        {
            this.BoolInvertedIndex = boolInvertedIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoolValueType" /> class.
        /// </summary>
        public BoolValueType()
        {
        }
    }
}