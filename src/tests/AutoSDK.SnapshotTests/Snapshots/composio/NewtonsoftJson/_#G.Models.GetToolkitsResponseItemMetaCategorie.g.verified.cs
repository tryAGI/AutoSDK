//HintName: G.Models.GetToolkitsResponseItemMetaCategorie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetToolkitsResponseItemMetaCategorie
    {
        /// <summary>
        /// Category identifier<br/>
        /// Example: developer-tools
        /// </summary>
        /// <example>developer-tools</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Human-readable category name<br/>
        /// Example: Developer Tools
        /// </summary>
        /// <example>Developer Tools</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsResponseItemMetaCategorie" /> class.
        /// </summary>
        /// <param name="id">
        /// Category identifier<br/>
        /// Example: developer-tools
        /// </param>
        /// <param name="name">
        /// Human-readable category name<br/>
        /// Example: Developer Tools
        /// </param>
        public GetToolkitsResponseItemMetaCategorie(
            string id,
            string name)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsResponseItemMetaCategorie" /> class.
        /// </summary>
        public GetToolkitsResponseItemMetaCategorie()
        {
        }
    }
}