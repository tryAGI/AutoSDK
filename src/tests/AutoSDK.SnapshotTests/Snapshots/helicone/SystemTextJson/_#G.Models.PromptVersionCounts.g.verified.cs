//HintName: G.Models.PromptVersionCounts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptVersionCounts
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalVersions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalVersions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("majorVersions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MajorVersions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionCounts" /> class.
        /// </summary>
        /// <param name="totalVersions"></param>
        /// <param name="majorVersions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptVersionCounts(
            double totalVersions,
            double majorVersions)
        {
            this.TotalVersions = totalVersions;
            this.MajorVersions = majorVersions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionCounts" /> class.
        /// </summary>
        public PromptVersionCounts()
        {
        }
    }
}