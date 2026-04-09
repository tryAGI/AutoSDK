//HintName: G.Models.GetViewerResponseBodyDataDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetViewerResponseBodyDataDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_method")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetViewerResponseBodyDataDiscriminatorAuthMethodJsonConverter))]
        public global::G.GetViewerResponseBodyDataDiscriminatorAuthMethod? AuthMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetViewerResponseBodyDataDiscriminator" /> class.
        /// </summary>
        /// <param name="authMethod"></param>
        public GetViewerResponseBodyDataDiscriminator(
            global::G.GetViewerResponseBodyDataDiscriminatorAuthMethod? authMethod)
        {
            this.AuthMethod = authMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetViewerResponseBodyDataDiscriminator" /> class.
        /// </summary>
        public GetViewerResponseBodyDataDiscriminator()
        {
        }
    }
}