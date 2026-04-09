//HintName: G.Models.CreateUserResponseBodyDataDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateUserResponseBodyDataDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_method")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateUserResponseBodyDataDiscriminatorAuthMethodJsonConverter))]
        public global::G.CreateUserResponseBodyDataDiscriminatorAuthMethod? AuthMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserResponseBodyDataDiscriminator" /> class.
        /// </summary>
        /// <param name="authMethod"></param>
        public CreateUserResponseBodyDataDiscriminator(
            global::G.CreateUserResponseBodyDataDiscriminatorAuthMethod? authMethod)
        {
            this.AuthMethod = authMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserResponseBodyDataDiscriminator" /> class.
        /// </summary>
        public CreateUserResponseBodyDataDiscriminator()
        {
        }
    }
}