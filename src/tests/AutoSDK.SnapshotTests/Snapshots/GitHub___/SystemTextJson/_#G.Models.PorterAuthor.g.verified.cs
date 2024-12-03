//HintName: G.Models.PorterAuthor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Porter Author
    /// </summary>
    public sealed partial class PorterAuthor
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
        [global::System.Text.Json.Serialization.JsonPropertyName("remote_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RemoteId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remote_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RemoteName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("import_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImportUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PorterAuthor" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="remoteId"></param>
        /// <param name="remoteName"></param>
        /// <param name="email"></param>
        /// <param name="name"></param>
        /// <param name="url"></param>
        /// <param name="importUrl"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PorterAuthor(
            int id,
            string remoteId,
            string remoteName,
            string email,
            string name,
            string url,
            string importUrl)
        {
            this.Id = id;
            this.RemoteId = remoteId ?? throw new global::System.ArgumentNullException(nameof(remoteId));
            this.RemoteName = remoteName ?? throw new global::System.ArgumentNullException(nameof(remoteName));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ImportUrl = importUrl ?? throw new global::System.ArgumentNullException(nameof(importUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PorterAuthor" /> class.
        /// </summary>
        public PorterAuthor()
        {
        }
    }
}