//HintName: G.Models.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationRequiredItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationRequiredItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("displayName", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default")]
        public string? Default { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Required { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("legacy_template_name")]
        public string? LegacyTemplateName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationRequiredItem" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="displayName"></param>
        /// <param name="type"></param>
        /// <param name="description"></param>
        /// <param name="required"></param>
        /// <param name="default"></param>
        /// <param name="legacyTemplateName"></param>
        public GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationRequiredItem(
            string name,
            string displayName,
            string type,
            string description,
            bool required,
            string? @default,
            string? legacyTemplateName)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Default = @default;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Required = required;
            this.LegacyTemplateName = legacyTemplateName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationRequiredItem" /> class.
        /// </summary>
        public GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationRequiredItem()
        {
        }
    }
}