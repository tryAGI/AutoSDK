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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Optional description of what content belongs in this category.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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