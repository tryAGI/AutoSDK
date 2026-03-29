//HintName: G.Models.UpdateRateLimitsPolicyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateRateLimitsPolicyRequest
    {
        /// <summary>
        /// Policy name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Rate unit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unit")]
        public global::G.UpdateRateLimitsPolicyRequestUnit? Unit { get; set; }

        /// <summary>
        /// Rate limit value
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public double? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRateLimitsPolicyRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Policy name
        /// </param>
        /// <param name="unit">
        /// Rate unit
        /// </param>
        /// <param name="value">
        /// Rate limit value
        /// </param>
        public UpdateRateLimitsPolicyRequest(
            string? name,
            global::G.UpdateRateLimitsPolicyRequestUnit? unit,
            double? value)
        {
            this.Name = name;
            this.Unit = unit;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRateLimitsPolicyRequest" /> class.
        /// </summary>
        public UpdateRateLimitsPolicyRequest()
        {
        }
    }
}