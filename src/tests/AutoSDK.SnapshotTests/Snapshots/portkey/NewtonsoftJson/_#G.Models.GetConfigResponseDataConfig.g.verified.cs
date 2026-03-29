//HintName: G.Models.GetConfigResponseDataConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConfigResponseDataConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retry")]
        public global::G.GetConfigResponseDataConfigRetry? Retry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache")]
        public global::G.GetConfigResponseDataConfigCache? Cache { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strategy")]
        public global::G.GetConfigResponseDataConfigStrategy? Strategy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("targets")]
        public global::System.Collections.Generic.IList<global::G.GetConfigResponseDataConfigTarget>? Targets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigResponseDataConfig" /> class.
        /// </summary>
        /// <param name="retry"></param>
        /// <param name="cache"></param>
        /// <param name="strategy"></param>
        /// <param name="targets"></param>
        public GetConfigResponseDataConfig(
            global::G.GetConfigResponseDataConfigRetry? retry,
            global::G.GetConfigResponseDataConfigCache? cache,
            global::G.GetConfigResponseDataConfigStrategy? strategy,
            global::System.Collections.Generic.IList<global::G.GetConfigResponseDataConfigTarget>? targets)
        {
            this.Retry = retry;
            this.Cache = cache;
            this.Strategy = strategy;
            this.Targets = targets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigResponseDataConfig" /> class.
        /// </summary>
        public GetConfigResponseDataConfig()
        {
        }
    }
}