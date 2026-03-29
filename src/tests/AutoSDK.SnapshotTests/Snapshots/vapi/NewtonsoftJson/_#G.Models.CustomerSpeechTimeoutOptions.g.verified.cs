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
        [global::Newtonsoft.Json.JsonProperty("timeoutSeconds", Required = global::Newtonsoft.Json.Required.Always)]
        public double TimeoutSeconds { get; set; } = default!;

        /// <summary>
        /// This is the maximum number of times the hook will trigger in a call.<br/>
        /// @default 3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggerMaxCount")]
        public double? TriggerMaxCount { get; set; }

        /// <summary>
        /// This is whether the counter for hook trigger resets the user speaks.<br/>
        /// @default never
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggerResetMode")]
        public object? TriggerResetMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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