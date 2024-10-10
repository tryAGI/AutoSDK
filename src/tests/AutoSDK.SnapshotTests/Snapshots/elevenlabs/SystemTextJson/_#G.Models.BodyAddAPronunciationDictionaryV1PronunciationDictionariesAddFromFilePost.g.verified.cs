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
        /// The name of the pronunciation dictionary, used for identification only.
        /// </summary>
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
        /// A description of the pronunciation dictionary, used for identification only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Should be one of 'editor' or 'viewer'. If not provided, defaults to no access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccessJsonConverter))]
        public global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess? WorkspaceAccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}