//HintName: G.Models.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminator(
            global::G.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminator" /> class.
        /// </summary>
        public CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminator()
        {
        }
    }
}