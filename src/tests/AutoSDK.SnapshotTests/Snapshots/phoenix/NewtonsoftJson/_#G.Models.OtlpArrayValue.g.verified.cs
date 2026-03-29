//HintName: G.Models.OtlpArrayValue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OtlpArrayValue
    {
        /// <summary>
        /// Array of values. The array may be empty (contain 0 elements).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("values")]
        public global::System.Collections.Generic.IList<global::G.OtlpAnyValue>? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpArrayValue" /> class.
        /// </summary>
        /// <param name="values">
        /// Array of values. The array may be empty (contain 0 elements).
        /// </param>
        public OtlpArrayValue(
            global::System.Collections.Generic.IList<global::G.OtlpAnyValue>? values)
        {
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpArrayValue" /> class.
        /// </summary>
        public OtlpArrayValue()
        {
        }
    }
}