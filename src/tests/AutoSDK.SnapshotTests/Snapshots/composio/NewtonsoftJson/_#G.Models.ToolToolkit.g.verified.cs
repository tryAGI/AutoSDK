//HintName: G.Models.ToolToolkit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolToolkit
    {
        /// <summary>
        /// Unique identifier of the parent toolkit<br/>
        /// Example: github
        /// </summary>
        /// <example>github</example>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// Human-readable name of the parent toolkit<br/>
        /// Example: GitHub
        /// </summary>
        /// <example>GitHub</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// URL to the toolkit logo image<br/>
        /// Example: https://github.githubassets.com/assets/GitHub-Mark-ea2971cee799.png
        /// </summary>
        /// <example>https://github.githubassets.com/assets/GitHub-Mark-ea2971cee799.png</example>
        [global::Newtonsoft.Json.JsonProperty("logo", Required = global::Newtonsoft.Json.Required.Always)]
        public string Logo { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolToolkit" /> class.
        /// </summary>
        /// <param name="slug">
        /// Unique identifier of the parent toolkit<br/>
        /// Example: github
        /// </param>
        /// <param name="name">
        /// Human-readable name of the parent toolkit<br/>
        /// Example: GitHub
        /// </param>
        /// <param name="logo">
        /// URL to the toolkit logo image<br/>
        /// Example: https://github.githubassets.com/assets/GitHub-Mark-ea2971cee799.png
        /// </param>
        public ToolToolkit(
            string slug,
            string name,
            string logo)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Logo = logo ?? throw new global::System.ArgumentNullException(nameof(logo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolToolkit" /> class.
        /// </summary>
        public ToolToolkit()
        {
        }
    }
}