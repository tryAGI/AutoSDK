//HintName: G.Models.UpdateGoogleCalendarOAuth2ClientCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateGoogleCalendarOAuth2ClientCredentialDTO
    {
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
        /// Initializes a new instance of the <see cref="UpdateGoogleCalendarOAuth2ClientCredentialDTO" /> class.
        /// </summary>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public UpdateGoogleCalendarOAuth2ClientCredentialDTO(
            string? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGoogleCalendarOAuth2ClientCredentialDTO" /> class.
        /// </summary>
        public UpdateGoogleCalendarOAuth2ClientCredentialDTO()
        {
        }
    }
}