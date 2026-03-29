//HintName: G.Models.OtlpKeyValueValueArrayValue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OtlpKeyValueValueArrayValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("values")]
        public global::System.Collections.Generic.IList<object>? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpKeyValueValueArrayValue" /> class.
        /// </summary>
        /// <param name="values"></param>
        public OtlpKeyValueValueArrayValue(
            global::System.Collections.Generic.IList<object>? values)
        {
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpKeyValueValueArrayValue" /> class.
        /// </summary>
        public OtlpKeyValueValueArrayValue()
        {
        }
    }
}