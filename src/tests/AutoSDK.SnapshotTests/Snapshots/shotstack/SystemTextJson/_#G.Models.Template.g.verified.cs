//HintName: G.Models.Template.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A template is a saved [Edit](#tocs_edit) than can be loaded and re-used.
    /// </summary>
    public sealed partial class Template
    {
        /// <summary>
        /// The template name<br/>
        /// Example: My template
        /// </summary>
        /// <example>My template</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// An edit defines the arrangement of a video on a timeline, an audio edit or an image design and the output format. Video assets are automatically preprocessed to fix common compatibility issues before rendering. You can control preprocessing behavior using the `transcode` flag on video assets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        public global::G.Edit? Template1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Template" /> class.
        /// </summary>
        /// <param name="name">
        /// The template name<br/>
        /// Example: My template
        /// </param>
        /// <param name="template1">
        /// An edit defines the arrangement of a video on a timeline, an audio edit or an image design and the output format. Video assets are automatically preprocessed to fix common compatibility issues before rendering. You can control preprocessing behavior using the `transcode` flag on video assets.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Template(
            string name,
            global::G.Edit? template1)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Template1 = template1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Template" /> class.
        /// </summary>
        public Template()
        {
        }
    }
}