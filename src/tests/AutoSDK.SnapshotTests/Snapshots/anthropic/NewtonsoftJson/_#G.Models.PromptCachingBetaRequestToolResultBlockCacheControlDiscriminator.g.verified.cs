//HintName: G.Models.PromptCachingBetaRequestToolResultBlockCacheControlDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptCachingBetaRequestToolResultBlockCacheControlDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PromptCachingBetaRequestToolResultBlockCacheControlDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCachingBetaRequestToolResultBlockCacheControlDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public PromptCachingBetaRequestToolResultBlockCacheControlDiscriminator(
            global::G.PromptCachingBetaRequestToolResultBlockCacheControlDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCachingBetaRequestToolResultBlockCacheControlDiscriminator" /> class.
        /// </summary>
        public PromptCachingBetaRequestToolResultBlockCacheControlDiscriminator()
        {
        }
    }
}