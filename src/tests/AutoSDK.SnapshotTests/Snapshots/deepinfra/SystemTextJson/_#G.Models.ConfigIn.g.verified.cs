//HintName: G.Models.ConfigIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfigIn
    {
        /// <summary>
        /// Set usage limit (in USD). Negative means no limit.null/not-set means don't change it
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigIn" /> class.
        /// </summary>
        /// <param name="limit">
        /// Set usage limit (in USD). Negative means no limit.null/not-set means don't change it
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigIn(
            double? limit)
        {
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigIn" /> class.
        /// </summary>
        public ConfigIn()
        {
        }
    }
}