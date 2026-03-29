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
        [global::System.Text.Json.Serialization.JsonPropertyName("bool_inverted_index")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<object, global::G.BoolInvertedIndexType>))]
        public global::G.OneOf<object, global::G.BoolInvertedIndexType>? BoolInvertedIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BoolValueType" /> class.
        /// </summary>
        /// <param name="boolInvertedIndex"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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