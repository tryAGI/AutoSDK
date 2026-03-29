//HintName: G.Models.IntValueType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Integer value type index configurations
    /// </summary>
    public sealed partial class IntValueType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("int_inverted_index")]
        public global::G.OneOf<object, global::G.IntInvertedIndexType>? IntInvertedIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntValueType" /> class.
        /// </summary>
        /// <param name="intInvertedIndex"></param>
        public IntValueType(
            global::G.OneOf<object, global::G.IntInvertedIndexType>? intInvertedIndex)
        {
            this.IntInvertedIndex = intInvertedIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntValueType" /> class.
        /// </summary>
        public IntValueType()
        {
        }
    }
}