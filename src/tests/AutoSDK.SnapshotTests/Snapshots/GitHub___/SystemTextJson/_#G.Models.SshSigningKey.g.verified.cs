//HintName: G.Models.SshSigningKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A public SSH key used to sign Git commits
    /// </summary>
    public sealed partial class SshSigningKey
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SshSigningKey" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="createdAt"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SshSigningKey(
            string key,
            int id,
            string title,
            global::System.DateTime createdAt)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Id = id;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SshSigningKey" /> class.
        /// </summary>
        public SshSigningKey()
        {
        }
    }
}