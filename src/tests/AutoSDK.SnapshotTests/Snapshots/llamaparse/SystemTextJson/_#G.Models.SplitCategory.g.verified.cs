//HintName: G.Models.SplitCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Category definition for document splitting.
    /// </summary>
    public sealed partial class SplitCategory
    {
        /// <summary>
        /// Name of the category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional description of what content belongs in this category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitCategory" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the category.
        /// </param>
        /// <param name="description">
        /// Optional description of what content belongs in this category.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SplitCategory(
            string name,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitCategory" /> class.
        /// </summary>
        public SplitCategory()
        {
        }
    }
}