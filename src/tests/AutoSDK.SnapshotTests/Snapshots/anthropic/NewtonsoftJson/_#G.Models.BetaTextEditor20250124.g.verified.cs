//HintName: G.Models.BetaTextEditor20250124.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaTextEditor20250124
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_control")]
        public global::G.BetaCacheControlEphemeral? CacheControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaTextEditor20250124Type Type { get; set; }

        /// <summary>
        /// Name of the tool.<br/>
        /// This is how the tool will be called by the model and in tool_use blocks.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public global::G.BetaTextEditor20250124Name Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTextEditor20250124" /> class.
        /// </summary>
        /// <param name="cacheControl"></param>
        /// <param name="type"></param>
        /// <param name="name">
        /// Name of the tool.<br/>
        /// This is how the tool will be called by the model and in tool_use blocks.
        /// </param>
        public BetaTextEditor20250124(
            global::G.BetaCacheControlEphemeral? cacheControl,
            global::G.BetaTextEditor20250124Type type,
            global::G.BetaTextEditor20250124Name name)
        {
            this.CacheControl = cacheControl;
            this.Type = type;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTextEditor20250124" /> class.
        /// </summary>
        public BetaTextEditor20250124()
        {
        }
    }
}