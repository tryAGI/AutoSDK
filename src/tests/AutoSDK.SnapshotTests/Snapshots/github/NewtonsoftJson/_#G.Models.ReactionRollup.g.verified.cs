//HintName: G.Models.ReactionRollup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReactionRollup
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("+1", Required = global::Newtonsoft.Json.Required.Always)]
        public int Plus1 { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("-1", Required = global::Newtonsoft.Json.Required.Always)]
        public int Minus1 { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("laugh", Required = global::Newtonsoft.Json.Required.Always)]
        public int Laugh { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confused", Required = global::Newtonsoft.Json.Required.Always)]
        public int Confused { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("heart", Required = global::Newtonsoft.Json.Required.Always)]
        public int Heart { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hooray", Required = global::Newtonsoft.Json.Required.Always)]
        public int Hooray { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eyes", Required = global::Newtonsoft.Json.Required.Always)]
        public int Eyes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rocket", Required = global::Newtonsoft.Json.Required.Always)]
        public int Rocket { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReactionRollup" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="totalCount"></param>
        /// <param name="plus1"></param>
        /// <param name="minus1"></param>
        /// <param name="laugh"></param>
        /// <param name="confused"></param>
        /// <param name="heart"></param>
        /// <param name="hooray"></param>
        /// <param name="eyes"></param>
        /// <param name="rocket"></param>
        public ReactionRollup(
            string url,
            int totalCount,
            int plus1,
            int minus1,
            int laugh,
            int confused,
            int heart,
            int hooray,
            int eyes,
            int rocket)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.TotalCount = totalCount;
            this.Plus1 = plus1;
            this.Minus1 = minus1;
            this.Laugh = laugh;
            this.Confused = confused;
            this.Heart = heart;
            this.Hooray = hooray;
            this.Eyes = eyes;
            this.Rocket = rocket;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReactionRollup" /> class.
        /// </summary>
        public ReactionRollup()
        {
        }
    }
}