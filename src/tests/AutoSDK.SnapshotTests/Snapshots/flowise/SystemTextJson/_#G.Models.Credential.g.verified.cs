//HintName: G.Models.Credential.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Credential
    {
        /// <summary>
        /// Example: cfd531e0-82fc-11e9-bc42-526af7764f64
        /// </summary>
        /// <example>cfd531e0-82fc-11e9-bc42-526af7764f64</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Example: My Credential
        /// </summary>
        /// <example>My Credential</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: openAIAPI
        /// </summary>
        /// <example>openAIAPI</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentialName")]
        public string? CredentialName { get; set; }

        /// <summary>
        /// Example: U2FsdGVkX1/3T2gnnsEtX6FJi1DbnYx0VVdS3XWZ5ro=
        /// </summary>
        /// <example>U2FsdGVkX1/3T2gnnsEtX6FJi1DbnYx0VVdS3XWZ5ro=</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("encryptedData")]
        public string? EncryptedData { get; set; }

        /// <summary>
        /// Example: 2024-08-24T14:15:22Z
        /// </summary>
        /// <example>2024-08-24T14:15:22Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Example: 2024-08-24T14:15:22Z
        /// </summary>
        /// <example>2024-08-24T14:15:22Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedDate")]
        public global::System.DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Credential" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: cfd531e0-82fc-11e9-bc42-526af7764f64
        /// </param>
        /// <param name="name">
        /// Example: My Credential
        /// </param>
        /// <param name="credentialName">
        /// Example: openAIAPI
        /// </param>
        /// <param name="encryptedData">
        /// Example: U2FsdGVkX1/3T2gnnsEtX6FJi1DbnYx0VVdS3XWZ5ro=
        /// </param>
        /// <param name="createdDate">
        /// Example: 2024-08-24T14:15:22Z
        /// </param>
        /// <param name="updatedDate">
        /// Example: 2024-08-24T14:15:22Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Credential(
            string? id,
            string? name,
            string? credentialName,
            string? encryptedData,
            global::System.DateTime? createdDate,
            global::System.DateTime? updatedDate)
        {
            this.Id = id;
            this.Name = name;
            this.CredentialName = credentialName;
            this.EncryptedData = encryptedData;
            this.CreatedDate = createdDate;
            this.UpdatedDate = updatedDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Credential" /> class.
        /// </summary>
        public Credential()
        {
        }
    }
}