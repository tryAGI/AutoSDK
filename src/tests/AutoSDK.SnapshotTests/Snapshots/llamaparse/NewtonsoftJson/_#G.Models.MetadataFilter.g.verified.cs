//HintName: G.Models.MetadataFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Comprehensive metadata filter for vector stores to support more operators.<br/>
    /// Value uses Strict types, as int, float and str are compatible types and were all<br/>
    /// converted to string before.<br/>
    /// See: https://docs.pydantic.dev/latest/usage/types/#strict-types
    /// </summary>
    public sealed partial class MetadataFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<int?, double?, string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>, object> Value { get; set; } = default!;

        /// <summary>
        /// Vector store filter operator.<br/>
        /// Default Value: ==
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operator")]
        public global::G.FilterOperator? Operator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataFilter" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="operator">
        /// Vector store filter operator.<br/>
        /// Default Value: ==
        /// </param>
        public MetadataFilter(
            string key,
            global::G.AnyOf<int?, double?, string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>, object> value,
            global::G.FilterOperator? @operator)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value;
            this.Operator = @operator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataFilter" /> class.
        /// </summary>
        public MetadataFilter()
        {
        }
    }
}