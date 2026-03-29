//HintName: G.Models.UsageInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Resource usage information.
    /// </summary>
    public sealed partial class UsageInfo
    {
        /// <summary>
        /// The current usage of the resource<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current")]
        public string? Current { get; set; }

        /// <summary>
        /// The limit of the resource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public string? Limit { get; set; }

        /// <summary>
        /// The unit of the resource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        public string? Unit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageInfo" /> class.
        /// </summary>
        /// <param name="current">
        /// The current usage of the resource<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// The limit of the resource
        /// </param>
        /// <param name="unit">
        /// The unit of the resource
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageInfo(
            string? current,
            string? limit,
            string? unit)
        {
            this.Current = current;
            this.Limit = limit;
            this.Unit = unit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageInfo" /> class.
        /// </summary>
        public UsageInfo()
        {
        }
    }
}