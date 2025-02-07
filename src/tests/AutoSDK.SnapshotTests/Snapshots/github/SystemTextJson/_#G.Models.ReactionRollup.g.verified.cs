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
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("+1")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Plus1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("-1")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Minus1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("laugh")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Laugh { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confused")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Confused { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heart")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Heart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hooray")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Hooray { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eyes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Eyes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rocket")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Rocket { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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