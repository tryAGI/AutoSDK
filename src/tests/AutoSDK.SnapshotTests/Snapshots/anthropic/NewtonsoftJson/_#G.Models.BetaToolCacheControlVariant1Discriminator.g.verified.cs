//HintName: G.Models.BetaToolCacheControlVariant1Discriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaToolCacheControlVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaToolCacheControlVariant1DiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaToolCacheControlVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public BetaToolCacheControlVariant1Discriminator(
            global::G.BetaToolCacheControlVariant1DiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaToolCacheControlVariant1Discriminator" /> class.
        /// </summary>
        public BetaToolCacheControlVariant1Discriminator()
        {
        }
    }
}