//HintName: G.Models.ClusterGet.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class ClusterGet
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CredentialId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterGet" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="provider"></param>
        /// <param name="name"></param>
        /// <param name="state"></param>
        /// <param name="credentialId"></param>
        /// <param name="errorMessage"></param>
        /// <param name="location"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ClusterGet(
            string id,
            string provider,
            string name,
            string state,
            string credentialId,
            string? errorMessage,
            string? location)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.CredentialId = credentialId ?? throw new global::System.ArgumentNullException(nameof(credentialId));
            this.ErrorMessage = errorMessage;
            this.Location = location;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterGet" /> class.
        /// </summary>
        public ClusterGet()
        {
        }
    }
}