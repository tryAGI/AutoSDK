//HintName: G.Models.UpdateApiKeyObjectRateLimit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateApiKeyObjectRateLimit
    {
        /// <summary>
        /// Example: requests
        /// </summary>
        /// <example>requests</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Example: rpm
        /// </summary>
        /// <example>rpm</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        public string? Unit { get; set; }

        /// <summary>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public int? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApiKeyObjectRateLimit" /> class.
        /// </summary>
        /// <param name="type">
        /// Example: requests
        /// </param>
        /// <param name="unit">
        /// Example: rpm
        /// </param>
        /// <param name="value">
        /// Example: 100
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateApiKeyObjectRateLimit(
            string? type,
            string? unit,
            int? value)
        {
            this.Type = type;
            this.Unit = unit;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApiKeyObjectRateLimit" /> class.
        /// </summary>
        public UpdateApiKeyObjectRateLimit()
        {
        }
    }
}