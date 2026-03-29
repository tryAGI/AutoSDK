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
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.CreateEmailCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// The recipient email address for alerts
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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