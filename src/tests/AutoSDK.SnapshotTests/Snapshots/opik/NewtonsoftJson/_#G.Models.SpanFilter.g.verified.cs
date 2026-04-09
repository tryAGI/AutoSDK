//HintName: G.Models.SpanFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpanFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("field")]
        public string? Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operator")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SpanFilterOperatorJsonConverter))]
        public global::G.SpanFilterOperator? Operator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key")]
        public string? Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanFilter" /> class.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="operator"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public SpanFilter(
            string? field,
            global::G.SpanFilterOperator? @operator,
            string? key,
            string? value)
        {
            this.Field = field;
            this.Operator = @operator;
            this.Key = key;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanFilter" /> class.
        /// </summary>
        public SpanFilter()
        {
        }
    }
}