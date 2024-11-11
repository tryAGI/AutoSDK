//HintName: G.Models.CustomRewardMaxPerUserPerStreamSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The settings used to determine whether to apply a maximum to the number of redemptions allowed per user per live stream.
    /// </summary>
    public sealed partial class CustomRewardMaxPerUserPerStreamSetting
    {
        /// <summary>
        /// A Boolean value that determines whether the reward applies a limit on the number of redemptions allowed per user per live stream. Is **true** if the reward applies a limit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsEnabled { get; set; } = default!;

        /// <summary>
        /// The maximum number of redemptions allowed per user per live stream.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_per_user_per_stream", Required = global::Newtonsoft.Json.Required.Always)]
        public long MaxPerUserPerStream { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRewardMaxPerUserPerStreamSetting" /> class.
        /// </summary>
        /// <param name="isEnabled">
        /// A Boolean value that determines whether the reward applies a limit on the number of redemptions allowed per user per live stream. Is **true** if the reward applies a limit.
        /// </param>
        /// <param name="maxPerUserPerStream">
        /// The maximum number of redemptions allowed per user per live stream.
        /// </param>
        public CustomRewardMaxPerUserPerStreamSetting(
            bool isEnabled,
            long maxPerUserPerStream)
        {
            this.IsEnabled = isEnabled;
            this.MaxPerUserPerStream = maxPerUserPerStream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRewardMaxPerUserPerStreamSetting" /> class.
        /// </summary>
        public CustomRewardMaxPerUserPerStreamSetting()
        {
        }
    }
}