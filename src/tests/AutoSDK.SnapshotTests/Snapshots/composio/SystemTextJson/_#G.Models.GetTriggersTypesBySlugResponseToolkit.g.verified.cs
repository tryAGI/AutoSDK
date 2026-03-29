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
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Deprecated: Use slug instead<br/>
        /// Example: Slack
        /// </summary>
        /// <example>Slack</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Logo of the toolkit<br/>
        /// Example: https://example.com/logo.png
        /// </summary>
        /// <example>https://example.com/logo.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Logo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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