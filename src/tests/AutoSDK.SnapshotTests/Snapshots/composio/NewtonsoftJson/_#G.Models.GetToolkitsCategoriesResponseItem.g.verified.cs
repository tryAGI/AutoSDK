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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// URL-friendly unique identifier for the category, used for filtering toolkits<br/>
        /// Example: developer-tools
        /// </summary>
        /// <example>developer-tools</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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