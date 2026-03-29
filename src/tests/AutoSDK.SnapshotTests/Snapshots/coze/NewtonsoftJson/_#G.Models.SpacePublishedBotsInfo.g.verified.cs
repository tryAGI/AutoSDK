//HintName: G.Models.SpacePublishedBotsInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpacePublishedBotsInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("space_bots")]
        public global::System.Collections.Generic.IList<global::G.SpacePublishedBots>? SpaceBots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpacePublishedBotsInfo" /> class.
        /// </summary>
        /// <param name="spaceBots"></param>
        /// <param name="total"></param>
        public SpacePublishedBotsInfo(
            global::System.Collections.Generic.IList<global::G.SpacePublishedBots>? spaceBots,
            int? total)
        {
            this.SpaceBots = spaceBots;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpacePublishedBotsInfo" /> class.
        /// </summary>
        public SpacePublishedBotsInfo()
        {
        }
    }
}