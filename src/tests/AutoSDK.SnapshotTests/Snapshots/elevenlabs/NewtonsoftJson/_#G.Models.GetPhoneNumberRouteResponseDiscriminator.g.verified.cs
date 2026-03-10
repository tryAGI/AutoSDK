//HintName: G.Models.GetPhoneNumberRouteResponseDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPhoneNumberRouteResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.GetPhoneNumberRouteResponseDiscriminatorProvider? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumberRouteResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="provider"></param>
        public GetPhoneNumberRouteResponseDiscriminator(
            global::G.GetPhoneNumberRouteResponseDiscriminatorProvider? provider)
        {
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumberRouteResponseDiscriminator" /> class.
        /// </summary>
        public GetPhoneNumberRouteResponseDiscriminator()
        {
        }
    }
}