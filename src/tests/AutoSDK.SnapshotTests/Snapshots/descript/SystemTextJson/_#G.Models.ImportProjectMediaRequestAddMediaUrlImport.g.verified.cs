//HintName: G.Models.ImportProjectMediaRequestAddMediaUrlImport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Import media from a URL
    /// </summary>
    public sealed partial class ImportProjectMediaRequestAddMediaUrlImport
    {
        /// <summary>
        /// URL to import media from. Must be accessible by Descript servers and support Range requests.<br/>
        /// Recommended to sign URLs for 12-48 hours to reduce chance of failure.<br/>
        /// Example: https://example.com/intro.mp4
        /// </summary>
        /// <example>https://example.com/intro.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// **[Work in progress]** This property is not yet supported and will be ignored if provided. Language is currently auto-detected.<br/>
        /// ISO 639-1 language code for transcription (e.g., "en", "es", "fr").<br/>
        /// If not specified, language is auto-detected from the audio.<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportProjectMediaRequestAddMediaUrlImport" /> class.
        /// </summary>
        /// <param name="url">
        /// URL to import media from. Must be accessible by Descript servers and support Range requests.<br/>
        /// Recommended to sign URLs for 12-48 hours to reduce chance of failure.<br/>
        /// Example: https://example.com/intro.mp4
        /// </param>
        /// <param name="language">
        /// **[Work in progress]** This property is not yet supported and will be ignored if provided. Language is currently auto-detected.<br/>
        /// ISO 639-1 language code for transcription (e.g., "en", "es", "fr").<br/>
        /// If not specified, language is auto-detected from the audio.<br/>
        /// Example: en
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportProjectMediaRequestAddMediaUrlImport(
            string url,
            string? language)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportProjectMediaRequestAddMediaUrlImport" /> class.
        /// </summary>
        public ImportProjectMediaRequestAddMediaUrlImport()
        {
        }
    }
}