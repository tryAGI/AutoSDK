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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Rate unit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdateRateLimitsPolicyRequestUnitJsonConverter))]
        public global::G.UpdateRateLimitsPolicyRequestUnit? Unit { get; set; }

        /// <summary>
        /// Rate limit value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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