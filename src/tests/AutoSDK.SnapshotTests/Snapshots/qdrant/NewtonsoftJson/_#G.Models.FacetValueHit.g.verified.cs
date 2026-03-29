//HintName: G.Models.FacetValueHit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FacetValueHit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FacetValue Value { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public int Count { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FacetValueHit" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="count"></param>
        public FacetValueHit(
            global::G.FacetValue value,
            int count)
        {
            this.Value = value;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FacetValueHit" /> class.
        /// </summary>
        public FacetValueHit()
        {
        }
    }
}