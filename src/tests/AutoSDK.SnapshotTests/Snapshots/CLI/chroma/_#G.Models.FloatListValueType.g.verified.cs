//HintName: G.Models.FloatListValueType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Float list value type index configurations (for vectors)
    /// </summary>
    public sealed partial class FloatListValueType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_index")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<object, global::G.VectorIndexType>))]
        public global::G.OneOf<object, global::G.VectorIndexType>? VectorIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FloatListValueType" /> class.
        /// </summary>
        /// <param name="vectorIndex"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FloatListValueType(
            global::G.OneOf<object, global::G.VectorIndexType>? vectorIndex)
        {
            this.VectorIndex = vectorIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FloatListValueType" /> class.
        /// </summary>
        public FloatListValueType()
        {
        }
    }
}