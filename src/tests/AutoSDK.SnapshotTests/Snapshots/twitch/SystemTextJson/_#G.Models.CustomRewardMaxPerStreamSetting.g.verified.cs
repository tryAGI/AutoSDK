//HintName: G.Models.CustomRewardMaxPerStreamSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The settings used to determine whether to apply a maximum to the number of redemptions allowed per live stream.
    /// </summary>
    public sealed partial class CustomRewardMaxPerStreamSetting
    {
        /// <summary>
        /// A Boolean value that determines whether the reward applies a limit on the number of redemptions allowed per live stream. Is **true** if the reward applies a limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsEnabled { get; set; }

        /// <summary>
        /// The maximum number of redemptions allowed per live stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_per_stream")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long MaxPerStream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRewardMaxPerStreamSetting" /> class.
        /// </summary>
        /// <param name="isEnabled">
        /// A Boolean value that determines whether the reward applies a limit on the number of redemptions allowed per live stream. Is **true** if the reward applies a limit.
        /// </param>
        /// <param name="maxPerStream">
        /// The maximum number of redemptions allowed per live stream.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomRewardMaxPerStreamSetting(
            bool isEnabled,
            long maxPerStream)
        {
            this.IsEnabled = isEnabled;
            this.MaxPerStream = maxPerStream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRewardMaxPerStreamSetting" /> class.
        /// </summary>
        public CustomRewardMaxPerStreamSetting()
        {
        }
    }
}