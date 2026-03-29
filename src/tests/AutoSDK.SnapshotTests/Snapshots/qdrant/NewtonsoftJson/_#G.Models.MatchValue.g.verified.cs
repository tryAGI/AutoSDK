//HintName: G.Models.MatchValue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Exact match of the given value
    /// </summary>
    public sealed partial class MatchValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ValueVariants Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchValue" /> class.
        /// </summary>
        /// <param name="value"></param>
        public MatchValue(
            global::G.ValueVariants value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchValue" /> class.
        /// </summary>
        public MatchValue()
        {
        }
    }
}