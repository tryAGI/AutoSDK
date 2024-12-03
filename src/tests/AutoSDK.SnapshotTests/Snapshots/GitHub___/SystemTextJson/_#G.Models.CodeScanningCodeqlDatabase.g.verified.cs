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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The name of the CodeQL database.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The language of the CodeQL database.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploader")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleUser Uploader { get; set; }

        /// <summary>
        /// The MIME type of the CodeQL database file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// The size of the CodeQL database file in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Size { get; set; }

        /// <summary>
        /// The date and time at which the CodeQL database was created, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time at which the CodeQL database was last updated, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The URL at which to download the CodeQL database. The `Accept` header must be set to the value of the `content_type` property.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The commit SHA of the repository at the time the CodeQL database was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_oid")]
        public string? CommitOid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningCodeqlDatabase" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the CodeQL database.
        /// </param>
        /// <param name="name">
        /// The name of the CodeQL database.
        /// </param>
        /// <param name="language">
        /// The language of the CodeQL database.
        /// </param>
        /// <param name="uploader">
        /// A GitHub user.
        /// </param>
        /// <param name="contentType">
        /// The MIME type of the CodeQL database file.
        /// </param>
        /// <param name="size">
        /// The size of the CodeQL database file in bytes.
        /// </param>
        /// <param name="createdAt">
        /// The date and time at which the CodeQL database was created, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </param>
        /// <param name="updatedAt">
        /// The date and time at which the CodeQL database was last updated, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </param>
        /// <param name="url">
        /// The URL at which to download the CodeQL database. The `Accept` header must be set to the value of the `content_type` property.
        /// </param>
        /// <param name="commitOid">
        /// The commit SHA of the repository at the time the CodeQL database was created.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CodeScanningCodeqlDatabase(
            int id,
            string name,
            string language,
            global::G.SimpleUser uploader,
            string contentType,
            int size,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string url,
            string? commitOid)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Uploader = uploader ?? throw new global::System.ArgumentNullException(nameof(uploader));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.Size = size;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.CommitOid = commitOid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningCodeqlDatabase" /> class.
        /// </summary>
        public CodeScanningCodeqlDatabase()
        {
        }
    }
}