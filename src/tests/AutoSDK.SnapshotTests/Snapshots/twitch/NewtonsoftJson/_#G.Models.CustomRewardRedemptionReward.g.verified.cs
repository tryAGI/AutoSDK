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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The reward’s title.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// The prompt displayed to the viewer if user input is required.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// The reward’s cost, in Channel Points.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost", Required = global::Newtonsoft.Json.Required.Always)]
        public long Cost { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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