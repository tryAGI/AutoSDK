//HintName: G.Models.CustomRewardRedemptionReward.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object that describes the reward that the user redeemed.
    /// </summary>
    public sealed partial class CustomRewardRedemptionReward
    {
        /// <summary>
        /// The ID that uniquely identifies the reward.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The reward’s title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The prompt displayed to the viewer if user input is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The reward’s cost, in Channel Points.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRewardRedemptionReward" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID that uniquely identifies the reward.
        /// </param>
        /// <param name="title">
        /// The reward’s title.
        /// </param>
        /// <param name="prompt">
        /// The prompt displayed to the viewer if user input is required.
        /// </param>
        /// <param name="cost">
        /// The reward’s cost, in Channel Points.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CustomRewardRedemptionReward(
            string id,
            string title,
            string prompt,
            long cost)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRewardRedemptionReward" /> class.
        /// </summary>
        public CustomRewardRedemptionReward()
        {
        }
    }
}