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
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<int?, double?, string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<int?, double?, string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>, object> Value { get; set; }

        /// <summary>
        /// Vector store filter operator.<br/>
        /// Default Value: ==
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FilterOperatorJsonConverter))]
        public global::G.FilterOperator? Operator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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