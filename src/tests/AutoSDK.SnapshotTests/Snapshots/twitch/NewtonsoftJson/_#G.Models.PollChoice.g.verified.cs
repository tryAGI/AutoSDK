//HintName: G.Models.PollChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PollChoice
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

        /// <summary>
        /// Initializes a new instance of the <see cref="PollChoice" /> class.
        /// </summary>
        /// <param name="id">
        /// An ID that identifies this choice.
        /// </param>
        /// <param name="title">
        /// The choice’s title. The title may contain a maximum of 25 characters.
        /// </param>
        /// <param name="votes">
        /// The total number of votes cast for this choice.
        /// </param>
        /// <param name="channelPointsVotes">
        /// The number of votes cast using Channel Points.
        /// </param>
        /// <param name="bitsVotes">
        /// Not used; will be set to 0.
        /// </param>
        public PollChoice(
            string id,
            string title,
            int votes,
            int channelPointsVotes,
            int bitsVotes)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Votes = votes;
            this.ChannelPointsVotes = channelPointsVotes;
            this.BitsVotes = bitsVotes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PollChoice" /> class.
        /// </summary>
        public PollChoice()
        {
        }
    }
}