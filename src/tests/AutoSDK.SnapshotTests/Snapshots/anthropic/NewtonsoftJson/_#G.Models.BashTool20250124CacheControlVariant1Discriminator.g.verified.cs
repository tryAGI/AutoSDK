//HintName: G.Models.BashTool20250124CacheControlVariant1Discriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BashTool20250124CacheControlVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BashTool20250124CacheControlVariant1DiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BashTool20250124CacheControlVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public BashTool20250124CacheControlVariant1Discriminator(
            global::G.BashTool20250124CacheControlVariant1DiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BashTool20250124CacheControlVariant1Discriminator" /> class.
        /// </summary>
        public BashTool20250124CacheControlVariant1Discriminator()
        {
        }
    }
}