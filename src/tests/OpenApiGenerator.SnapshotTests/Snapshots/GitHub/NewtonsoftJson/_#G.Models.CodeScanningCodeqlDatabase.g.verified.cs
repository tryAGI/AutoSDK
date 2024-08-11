//HintName: G.Models.CodeScanningCodeqlDatabase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A CodeQL database.
    /// </summary>
    public sealed partial class CodeScanningCodeqlDatabase
    {
        /// <summary>
        /// The ID of the CodeQL database.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The name of the CodeQL database.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The language of the CodeQL database.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string Language { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uploader", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUser? Uploader { get; set; } = default!;

        /// <summary>
        /// The MIME type of the CodeQL database file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContentType { get; set; } = default!;

        /// <summary>
        /// The size of the CodeQL database file in bytes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size", Required = global::Newtonsoft.Json.Required.Always)]
        public int Size { get; set; } = default!;

        /// <summary>
        /// The date and time at which the CodeQL database was created, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The date and time at which the CodeQL database was last updated, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// The URL at which to download the CodeQL database. The `Accept` header must be set to the value of the `content_type` property.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The commit SHA of the repository at the time the CodeQL database was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_oid")]
        public string? CommitOid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}