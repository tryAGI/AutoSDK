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
        [global::Newtonsoft.Json.JsonProperty("vector_index")]
        public global::G.OneOf<object, global::G.VectorIndexType>? VectorIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FloatListValueType" /> class.
        /// </summary>
        /// <param name="vectorIndex"></param>
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