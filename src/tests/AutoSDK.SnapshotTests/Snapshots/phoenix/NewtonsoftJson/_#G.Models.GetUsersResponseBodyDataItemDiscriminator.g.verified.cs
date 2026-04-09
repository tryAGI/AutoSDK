//HintName: G.Models.GetUsersResponseBodyDataItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUsersResponseBodyDataItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_method")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetUsersResponseBodyDataItemDiscriminatorAuthMethodJsonConverter))]
        public global::G.GetUsersResponseBodyDataItemDiscriminatorAuthMethod? AuthMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsersResponseBodyDataItemDiscriminator" /> class.
        /// </summary>
        /// <param name="authMethod"></param>
        public GetUsersResponseBodyDataItemDiscriminator(
            global::G.GetUsersResponseBodyDataItemDiscriminatorAuthMethod? authMethod)
        {
            this.AuthMethod = authMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsersResponseBodyDataItemDiscriminator" /> class.
        /// </summary>
        public GetUsersResponseBodyDataItemDiscriminator()
        {
        }
    }
}