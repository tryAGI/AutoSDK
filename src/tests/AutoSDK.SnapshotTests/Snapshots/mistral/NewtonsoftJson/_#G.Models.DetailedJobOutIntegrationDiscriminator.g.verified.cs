//HintName: G.Models.DetailedJobOutIntegrationDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetailedJobOutIntegrationDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.DetailedJobOutIntegrationDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedJobOutIntegrationDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public DetailedJobOutIntegrationDiscriminator(
            global::G.DetailedJobOutIntegrationDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedJobOutIntegrationDiscriminator" /> class.
        /// </summary>
        public DetailedJobOutIntegrationDiscriminator()
        {
        }
    }
}