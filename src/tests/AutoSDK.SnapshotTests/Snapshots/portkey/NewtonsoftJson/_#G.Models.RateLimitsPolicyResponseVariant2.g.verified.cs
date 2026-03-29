//HintName: G.Models.RateLimitsPolicyResponseVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RateLimitsPolicyResponseVariant2
    {
        /// <summary>
        /// Example: policy_rate_limits
        /// </summary>
        /// <example>policy_rate_limits</example>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitsPolicyResponseVariant2" /> class.
        /// </summary>
        /// <param name="object">
        /// Example: policy_rate_limits
        /// </param>
        public RateLimitsPolicyResponseVariant2(
            string? @object)
        {
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitsPolicyResponseVariant2" /> class.
        /// </summary>
        public RateLimitsPolicyResponseVariant2()
        {
        }
    }
}