//HintName: G.Models.ToolTextEditor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A tool for viewing, creating and editing files.
    /// </summary>
    public sealed partial class ToolTextEditor
    {
        /// <summary>
        /// The type of tool.<br/>
        /// Default Value: text_editor_20241022
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The name of the tool.<br/>
        /// Default Value: str_replace_editor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The cache control settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::G.CacheControlEphemeral? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolTextEditor" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool.<br/>
        /// Default Value: text_editor_20241022
        /// </param>
        /// <param name="name">
        /// The name of the tool.<br/>
        /// Default Value: str_replace_editor
        /// </param>
        /// <param name="cacheControl">
        /// The cache control settings.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ToolTextEditor(
            string? type,
            string? name,
            global::G.CacheControlEphemeral? cacheControl)
        {
            this.Type = type;
            this.Name = name;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolTextEditor" /> class.
        /// </summary>
        public ToolTextEditor()
        {
        }
    }
}