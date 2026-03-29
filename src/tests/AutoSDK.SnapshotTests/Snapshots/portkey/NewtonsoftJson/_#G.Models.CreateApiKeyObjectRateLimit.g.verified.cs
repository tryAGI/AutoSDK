//HintName: G.Models.CreateApiKeyObjectRateLimit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateApiKeyObjectRateLimit
    {
        /// <summary>
        /// Example: requests
        /// </summary>
        /// <example>requests</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Example: rpm
        /// </summary>
        /// <example>rpm</example>
        [global::Newtonsoft.Json.JsonProperty("unit")]
        public string? Unit { get; set; }

        /// <summary>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public int? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyObjectRateLimit" /> class.
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
        public CreateApiKeyObjectRateLimit(
            string? type,
            string? unit,
            int? value)
        {
            this.Type = type;
            this.Unit = unit;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyObjectRateLimit" /> class.
        /// </summary>
        public CreateApiKeyObjectRateLimit()
        {
        }
    }
}