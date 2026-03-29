//HintName: G.Models.CreateGoogleCalendarOAuth2ClientCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGoogleCalendarOAuth2ClientCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.CreateGoogleCalendarOAuth2ClientCredentialDTOProvider Provider { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateGoogleCalendarOAuth2ClientCredentialDTO" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public CreateGoogleCalendarOAuth2ClientCredentialDTO(
            global::G.CreateGoogleCalendarOAuth2ClientCredentialDTOProvider provider,
            string? name)
        {
            this.Provider = provider;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGoogleCalendarOAuth2ClientCredentialDTO" /> class.
        /// </summary>
        public CreateGoogleCalendarOAuth2ClientCredentialDTO()
        {
        }
    }
}