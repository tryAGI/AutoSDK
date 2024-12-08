//HintName: G.Models.BetaBashTool20241022CacheControlDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaBashTool20241022CacheControlDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaBashTool20241022CacheControlDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBashTool20241022CacheControlDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public BetaBashTool20241022CacheControlDiscriminator(
            global::G.BetaBashTool20241022CacheControlDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBashTool20241022CacheControlDiscriminator" /> class.
        /// </summary>
        public BetaBashTool20241022CacheControlDiscriminator()
        {
        }
    }
}