//HintName: G.Models.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost
    {
        /// <summary>
        /// The name of the pronunciation dictionary, used for identification only.<br/>
        /// Example: My Dictionary
        /// </summary>
        /// <example>My Dictionary</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A lexicon .pls file which we will use to initialize the project with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// A lexicon .pls file which we will use to initialize the project with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// A description of the pronunciation dictionary, used for identification only.<br/>
        /// Example: Contains pronunciation's of our character names
        /// </summary>
        /// <example>Contains pronunciation's of our character names</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Should be one of 'admin', 'editor' or 'viewer'. If not provided, defaults to no access.<br/>
        /// Example: viewer
        /// </summary>
        /// <example>viewer</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccessJsonConverter))]
        public global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess? WorkspaceAccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the pronunciation dictionary, used for identification only.<br/>
        /// Example: My Dictionary
        /// </param>
        /// <param name="file">
        /// A lexicon .pls file which we will use to initialize the project with.
        /// </param>
        /// <param name="filename">
        /// A lexicon .pls file which we will use to initialize the project with.
        /// </param>
        /// <param name="description">
        /// A description of the pronunciation dictionary, used for identification only.<br/>
        /// Example: Contains pronunciation's of our character names
        /// </param>
        /// <param name="workspaceAccess">
        /// Should be one of 'admin', 'editor' or 'viewer'. If not provided, defaults to no access.<br/>
        /// Example: viewer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost(
            string name,
            byte[]? file,
            string? filename,
            string? description,
            global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess? workspaceAccess)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.File = file;
            this.Filename = filename;
            this.Description = description;
            this.WorkspaceAccess = workspaceAccess;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost" /> class.
        /// </summary>
        public BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost()
        {
        }
    }
}