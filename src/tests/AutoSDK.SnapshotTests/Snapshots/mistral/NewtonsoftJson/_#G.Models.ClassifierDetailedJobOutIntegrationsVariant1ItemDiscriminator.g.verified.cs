//HintName: G.Models.ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminator(
            global::G.ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminator" /> class.
        /// </summary>
        public ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminator()
        {
        }
    }
}