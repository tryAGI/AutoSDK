//HintName: G.Models.ShardKeyWithFallback.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ShardKeyWithFallback
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ShardKey Target { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fallback", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ShardKey Fallback { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardKeyWithFallback" /> class.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="fallback"></param>
        public ShardKeyWithFallback(
            global::G.ShardKey target,
            global::G.ShardKey fallback)
        {
            this.Target = target;
            this.Fallback = fallback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardKeyWithFallback" /> class.
        /// </summary>
        public ShardKeyWithFallback()
        {
        }
    }
}