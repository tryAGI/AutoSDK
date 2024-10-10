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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A lexicon .pls file which we will use to initialize the project with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// A lexicon .pls file which we will use to initialize the project with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// A description of the pronunciation dictionary, used for identification only.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Should be one of 'editor' or 'viewer'. If not provided, defaults to no access.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_access")]
        public global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess? WorkspaceAccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}