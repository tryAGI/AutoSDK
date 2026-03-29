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
        [global::Newtonsoft.Json.JsonProperty("bool")]
        public global::G.OneOf<object, global::G.BoolValueType>? Bool { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("float")]
        public global::G.OneOf<object, global::G.FloatValueType>? Float { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("float_list")]
        public global::G.OneOf<object, global::G.FloatListValueType>? FloatList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("int")]
        public global::G.OneOf<object, global::G.IntValueType>? Int { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sparse_vector")]
        public global::G.OneOf<object, global::G.SparseVectorValueType>? SparseVector { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("string")]
        public global::G.OneOf<object, global::G.StringValueType>? String { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        public ValueTypes(
            global::G.OneOf<object, global::G.BoolValueType>? @bool,
            global::G.OneOf<object, global::G.FloatValueType>? @float,
            global::G.OneOf<object, global::G.FloatListValueType>? floatList,
            global::G.OneOf<object, global::G.IntValueType>? @int,
            global::G.OneOf<object, global::G.SparseVectorValueType>? sparseVector,
            global::G.OneOf<object, global::G.StringValueType>? @string)
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