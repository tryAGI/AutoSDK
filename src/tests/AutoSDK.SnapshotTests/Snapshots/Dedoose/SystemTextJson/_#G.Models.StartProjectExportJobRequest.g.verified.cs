//HintName: G.Models.StartProjectExportJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartProjectExportJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extension")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Extension { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encryptedSymKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EncryptedSymKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartProjectExportJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <param name="extension"></param>
        /// <param name="encryptedSymKey"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public StartProjectExportJobRequest(
            global::System.Guid projectId,
            string password,
            string email,
            string extension,
            string encryptedSymKey)
        {
            this.ProjectId = projectId;
            this.Password = password ?? throw new global::System.ArgumentNullException(nameof(password));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Extension = extension ?? throw new global::System.ArgumentNullException(nameof(extension));
            this.EncryptedSymKey = encryptedSymKey ?? throw new global::System.ArgumentNullException(nameof(encryptedSymKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartProjectExportJobRequest" /> class.
        /// </summary>
        public StartProjectExportJobRequest()
        {
        }
    }
}