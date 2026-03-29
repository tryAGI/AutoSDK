//HintName: G.Models.CreateUserRequestBodyUserDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateUserRequestBodyUserDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_method")]
        public global::G.CreateUserRequestBodyUserDiscriminatorAuthMethod? AuthMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserRequestBodyUserDiscriminator" /> class.
        /// </summary>
        /// <param name="authMethod"></param>
        public CreateUserRequestBodyUserDiscriminator(
            global::G.CreateUserRequestBodyUserDiscriminatorAuthMethod? authMethod)
        {
            this.AuthMethod = authMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserRequestBodyUserDiscriminator" /> class.
        /// </summary>
        public CreateUserRequestBodyUserDiscriminator()
        {
        }
    }
}