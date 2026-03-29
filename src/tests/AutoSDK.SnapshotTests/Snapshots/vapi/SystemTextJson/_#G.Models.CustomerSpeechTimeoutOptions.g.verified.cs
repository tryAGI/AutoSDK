//HintName: G.Models.CustomerSpeechTimeoutOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomerSpeechTimeoutOptions
    {
        /// <summary>
        /// This is the timeout in seconds before action is triggered.<br/>
        /// The clock starts when the assistant finishes speaking and remains active until the user speaks.<br/>
        /// @default 7.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeoutSeconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TimeoutSeconds { get; set; }

        /// <summary>
        /// This is the maximum number of times the hook will trigger in a call.<br/>
        /// @default 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerMaxCount")]
        public double? TriggerMaxCount { get; set; }

        /// <summary>
        /// This is whether the counter for hook trigger resets the user speaks.<br/>
        /// @default never
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerResetMode")]
        public object? TriggerResetMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerSpeechTimeoutOptions" /> class.
        /// </summary>
        /// <param name="timeoutSeconds">
        /// This is the timeout in seconds before action is triggered.<br/>
        /// The clock starts when the assistant finishes speaking and remains active until the user speaks.<br/>
        /// @default 7.5
        /// </param>
        /// <param name="triggerMaxCount">
        /// This is the maximum number of times the hook will trigger in a call.<br/>
        /// @default 3
        /// </param>
        /// <param name="triggerResetMode">
        /// This is whether the counter for hook trigger resets the user speaks.<br/>
        /// @default never
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomerSpeechTimeoutOptions(
            double timeoutSeconds,
            double? triggerMaxCount,
            object? triggerResetMode)
        {
            this.TimeoutSeconds = timeoutSeconds;
            this.TriggerMaxCount = triggerMaxCount;
            this.TriggerResetMode = triggerResetMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerSpeechTimeoutOptions" /> class.
        /// </summary>
        public CustomerSpeechTimeoutOptions()
        {
        }
    }
}