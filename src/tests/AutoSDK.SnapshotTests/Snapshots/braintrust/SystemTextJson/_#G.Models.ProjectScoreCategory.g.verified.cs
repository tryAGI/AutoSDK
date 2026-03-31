//HintName: G.Models.ProjectScoreCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// For categorical-type project scores, defines a single category
    /// </summary>
    public sealed partial class ProjectScoreCategory
    {
        /// <summary>
        /// Name of the category
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Numerical value of the category. Must be between 0 and 1, inclusive
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectScoreCategory" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the category
        /// </param>
        /// <param name="value">
        /// Numerical value of the category. Must be between 0 and 1, inclusive
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectScoreCategory(
            string name,
            double value)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectScoreCategory" /> class.
        /// </summary>
        public ProjectScoreCategory()
        {
        }
    }
}