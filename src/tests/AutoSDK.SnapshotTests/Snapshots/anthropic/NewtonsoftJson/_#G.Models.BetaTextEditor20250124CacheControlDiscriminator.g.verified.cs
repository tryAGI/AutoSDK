//HintName: G.Models.BetaTextEditor20250124CacheControlDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaTextEditor20250124CacheControlDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaTextEditor20250124CacheControlDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTextEditor20250124CacheControlDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public BetaTextEditor20250124CacheControlDiscriminator(
            global::G.BetaTextEditor20250124CacheControlDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTextEditor20250124CacheControlDiscriminator" /> class.
        /// </summary>
        public BetaTextEditor20250124CacheControlDiscriminator()
        {
        }
    }
}