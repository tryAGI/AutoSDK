//HintName: G.Models.BetaComputerUseTool20250124CacheControlVariant1Discriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaComputerUseTool20250124CacheControlVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaComputerUseTool20250124CacheControlVariant1DiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComputerUseTool20250124CacheControlVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public BetaComputerUseTool20250124CacheControlVariant1Discriminator(
            global::G.BetaComputerUseTool20250124CacheControlVariant1DiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComputerUseTool20250124CacheControlVariant1Discriminator" /> class.
        /// </summary>
        public BetaComputerUseTool20250124CacheControlVariant1Discriminator()
        {
        }
    }
}