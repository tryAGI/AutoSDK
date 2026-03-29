//HintName: G.Models.Map.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Map
    {
        /// <summary>
        /// For any additional_properties properties in the top_logprobs object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("additional_properties")]
        public double? AdditionalProperties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties2 { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Map" /> class.
        /// </summary>
        /// <param name="additionalProperties">
        /// For any additional_properties properties in the top_logprobs object
        /// </param>
        public Map(
            double? additionalProperties)
        {
            this.AdditionalProperties = additionalProperties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Map" /> class.
        /// </summary>
        public Map()
        {
        }
    }
}