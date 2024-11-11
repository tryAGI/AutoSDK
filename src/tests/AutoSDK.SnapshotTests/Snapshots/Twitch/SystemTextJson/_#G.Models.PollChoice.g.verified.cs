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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The choice’s title. The title may contain a maximum of 25 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The total number of votes cast for this choice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("votes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Votes { get; set; }

        /// <summary>
        /// The number of votes cast using Channel Points.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_points_votes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ChannelPointsVotes { get; set; }

        /// <summary>
        /// Not used; will be set to 0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bits_votes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BitsVotes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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