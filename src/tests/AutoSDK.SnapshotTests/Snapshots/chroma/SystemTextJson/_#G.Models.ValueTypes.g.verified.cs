//HintName: G.Models.ValueTypes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Strongly-typed value type configurations<br/>
    /// Contains optional configurations for each supported value type
    /// </summary>
    public sealed partial class ValueTypes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bool")]
        public global::G.BoolValueType? Bool { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("float")]
        public global::G.FloatValueType? Float { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("float_list")]
        public global::G.FloatListValueType? FloatList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("int")]
        public global::G.IntValueType? Int { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sparse_vector")]
        public global::G.SparseVectorValueType? SparseVector { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("string")]
        public global::G.StringValueType? String { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueTypes" /> class.
        /// </summary>
        /// <param name="bool"></param>
        /// <param name="float"></param>
        /// <param name="floatList"></param>
        /// <param name="int"></param>
        /// <param name="sparseVector"></param>
        /// <param name="string"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValueTypes(
            global::G.BoolValueType? @bool,
            global::G.FloatValueType? @float,
            global::G.FloatListValueType? floatList,
            global::G.IntValueType? @int,
            global::G.SparseVectorValueType? sparseVector,
            global::G.StringValueType? @string)
        {
            this.Bool = @bool;
            this.Float = @float;
            this.FloatList = floatList;
            this.Int = @int;
            this.SparseVector = sparseVector;
            this.String = @string;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueTypes" /> class.
        /// </summary>
        public ValueTypes()
        {
        }

    }
}