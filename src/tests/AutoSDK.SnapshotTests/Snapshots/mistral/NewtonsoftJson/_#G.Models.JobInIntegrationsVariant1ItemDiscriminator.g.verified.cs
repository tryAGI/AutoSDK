//HintName: G.Models.JobInIntegrationsVariant1ItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobInIntegrationsVariant1ItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.JobInIntegrationsVariant1ItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobInIntegrationsVariant1ItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public JobInIntegrationsVariant1ItemDiscriminator(
            global::G.JobInIntegrationsVariant1ItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobInIntegrationsVariant1ItemDiscriminator" /> class.
        /// </summary>
        public JobInIntegrationsVariant1ItemDiscriminator()
        {
        }
    }
}