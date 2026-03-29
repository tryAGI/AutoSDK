//HintName: G.Models.UsageLimitsPolicyResponseVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageLimitsPolicyResponseVariant2
    {
        /// <summary>
        /// Example: policy_usage_limits
        /// </summary>
        /// <example>policy_usage_limits</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageLimitsPolicyResponseVariant2" /> class.
        /// </summary>
        /// <param name="object">
        /// Example: policy_usage_limits
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageLimitsPolicyResponseVariant2(
            string? @object)
        {
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageLimitsPolicyResponseVariant2" /> class.
        /// </summary>
        public UsageLimitsPolicyResponseVariant2()
        {
        }
    }
}