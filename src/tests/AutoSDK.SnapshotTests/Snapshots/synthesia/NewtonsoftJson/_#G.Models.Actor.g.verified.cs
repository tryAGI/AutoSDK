//HintName: G.Models.Actor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Actor (who performed the action) information.
    /// </summary>
    public sealed partial class Actor
    {
        /// <summary>
        /// Types of actors that can perform actions.<br/>
        /// USER: A human user (authenticated via username/password, social login, or SAML SSO)<br/>
        /// SYSTEM: An automated system process (e.g., "billing_system", "moderation_system")<br/>
        /// SERVICE: An internal service (e.g., "rendering_service", "dubbing_service")
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ActorType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Actor" /> class.
        /// </summary>
        /// <param name="type">
        /// Types of actors that can perform actions.<br/>
        /// USER: A human user (authenticated via username/password, social login, or SAML SSO)<br/>
        /// SYSTEM: An automated system process (e.g., "billing_system", "moderation_system")<br/>
        /// SERVICE: An internal service (e.g., "rendering_service", "dubbing_service")
        /// </param>
        /// <param name="id"></param>
        /// <param name="name">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="email">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        public Actor(
            global::G.ActorType type,
            string id,
            string? name,
            string? email)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Actor" /> class.
        /// </summary>
        public Actor()
        {
        }
    }
}