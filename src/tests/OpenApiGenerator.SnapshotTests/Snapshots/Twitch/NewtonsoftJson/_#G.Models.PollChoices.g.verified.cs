//HintName: G.Models.PollChoices.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PollChoices
    {
        /// <summary>
        /// An ID that identifies this choice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The choice’s title. The title may contain a maximum of 25 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// The total number of votes cast for this choice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("votes", Required = global::Newtonsoft.Json.Required.Always)]
        public int Votes { get; set; } = default!;

        /// <summary>
        /// The number of votes cast using Channel Points.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel_points_votes", Required = global::Newtonsoft.Json.Required.Always)]
        public int ChannelPointsVotes { get; set; } = default!;

        /// <summary>
        /// Not used; will be set to 0.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bits_votes", Required = global::Newtonsoft.Json.Required.Always)]
        public int BitsVotes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}