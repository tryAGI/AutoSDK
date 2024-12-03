//HintName: G.Models.DeployKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An SSH key granting access to a single repository.
    /// </summary>
    public sealed partial class DeployKey
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Verified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_only")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ReadOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_by")]
        public string? AddedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used")]
        public string? LastUsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployKey" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="key"></param>
        /// <param name="url"></param>
        /// <param name="title"></param>
        /// <param name="verified"></param>
        /// <param name="createdAt"></param>
        /// <param name="readOnly"></param>
        /// <param name="addedBy"></param>
        /// <param name="lastUsed"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DeployKey(
            int id,
            string key,
            string url,
            string title,
            bool verified,
            string createdAt,
            bool readOnly,
            string? addedBy,
            string? lastUsed)
        {
            this.Id = id;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Verified = verified;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.ReadOnly = readOnly;
            this.AddedBy = addedBy;
            this.LastUsed = lastUsed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployKey" /> class.
        /// </summary>
        public DeployKey()
        {
        }
    }
}