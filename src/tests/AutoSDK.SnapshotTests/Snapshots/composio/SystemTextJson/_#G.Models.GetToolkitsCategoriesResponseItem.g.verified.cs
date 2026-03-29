//HintName: G.Models.GetToolkitsCategoriesResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about a single toolkit category
    /// </summary>
    public sealed partial class GetToolkitsCategoriesResponseItem
    {
        /// <summary>
        /// Display name of the toolkit category<br/>
        /// Example: Developer Tools
        /// </summary>
        /// <example>Developer Tools</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// URL-friendly unique identifier for the category, used for filtering toolkits<br/>
        /// Example: developer-tools
        /// </summary>
        /// <example>developer-tools</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsCategoriesResponseItem" /> class.
        /// </summary>
        /// <param name="name">
        /// Display name of the toolkit category<br/>
        /// Example: Developer Tools
        /// </param>
        /// <param name="id">
        /// URL-friendly unique identifier for the category, used for filtering toolkits<br/>
        /// Example: developer-tools
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetToolkitsCategoriesResponseItem(
            string name,
            string id)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsCategoriesResponseItem" /> class.
        /// </summary>
        public GetToolkitsCategoriesResponseItem()
        {
        }
    }
}