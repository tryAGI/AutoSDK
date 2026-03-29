//HintName: G.Models.GetToolkitsChangelogResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetToolkitsChangelogResponseItem
    {
        /// <summary>
        /// Toolkit slug
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// Toolkit name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Toolkit display name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// Array of version changelogs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetToolkitsChangelogResponseItemVersion> Versions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsChangelogResponseItem" /> class.
        /// </summary>
        /// <param name="slug">
        /// Toolkit slug
        /// </param>
        /// <param name="name">
        /// Toolkit name
        /// </param>
        /// <param name="displayName">
        /// Toolkit display name
        /// </param>
        /// <param name="versions">
        /// Array of version changelogs
        /// </param>
        public GetToolkitsChangelogResponseItem(
            string slug,
            string name,
            string displayName,
            global::System.Collections.Generic.IList<global::G.GetToolkitsChangelogResponseItemVersion> versions)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Versions = versions ?? throw new global::System.ArgumentNullException(nameof(versions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsChangelogResponseItem" /> class.
        /// </summary>
        public GetToolkitsChangelogResponseItem()
        {
        }
    }
}