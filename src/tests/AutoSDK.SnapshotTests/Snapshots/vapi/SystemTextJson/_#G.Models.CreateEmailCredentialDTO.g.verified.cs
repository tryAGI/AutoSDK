//HintName: G.Models.CreateEmailCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEmailCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateEmailCredentialDTOProviderJsonConverter))]
        public global::G.CreateEmailCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// The recipient email address for alerts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmailCredentialDTO" /> class.
        /// </summary>
        /// <param name="email">
        /// The recipient email address for alerts
        /// </param>
        /// <param name="provider"></param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEmailCredentialDTO(
            string email,
            global::G.CreateEmailCredentialDTOProvider provider,
            string? name)
        {
            this.Provider = provider;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmailCredentialDTO" /> class.
        /// </summary>
        public CreateEmailCredentialDTO()
        {
        }
    }
}