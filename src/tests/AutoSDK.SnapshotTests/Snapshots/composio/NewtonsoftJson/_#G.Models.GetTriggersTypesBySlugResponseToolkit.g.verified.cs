//HintName: G.Models.GetTriggersTypesBySlugResponseToolkit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about the toolkit that provides this trigger
    /// </summary>
    public sealed partial class GetTriggersTypesBySlugResponseToolkit
    {
        /// <summary>
        /// Unique identifier for the parent toolkit<br/>
        /// Example: slack
        /// </summary>
        /// <example>slack</example>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// Deprecated: Use slug instead<br/>
        /// Example: Slack
        /// </summary>
        /// <example>Slack</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Logo of the toolkit<br/>
        /// Example: https://example.com/logo.png
        /// </summary>
        /// <example>https://example.com/logo.png</example>
        [global::Newtonsoft.Json.JsonProperty("logo", Required = global::Newtonsoft.Json.Required.Always)]
        public string Logo { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTriggersTypesBySlugResponseToolkit" /> class.
        /// </summary>
        /// <param name="slug">
        /// Unique identifier for the parent toolkit<br/>
        /// Example: slack
        /// </param>
        /// <param name="name">
        /// Deprecated: Use slug instead<br/>
        /// Example: Slack
        /// </param>
        /// <param name="logo">
        /// Logo of the toolkit<br/>
        /// Example: https://example.com/logo.png
        /// </param>
        public GetTriggersTypesBySlugResponseToolkit(
            string slug,
            string name,
            string logo)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Logo = logo ?? throw new global::System.ArgumentNullException(nameof(logo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTriggersTypesBySlugResponseToolkit" /> class.
        /// </summary>
        public GetTriggersTypesBySlugResponseToolkit()
        {
        }
    }
}