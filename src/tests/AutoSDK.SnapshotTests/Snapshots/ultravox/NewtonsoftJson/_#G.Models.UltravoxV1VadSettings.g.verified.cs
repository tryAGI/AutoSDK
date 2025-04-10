//HintName: G.Models.UltravoxV1VadSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Call-level VAD settings.
    /// </summary>
    public sealed partial class UltravoxV1VadSettings
    {
        /// <summary>
        /// The minimum amount of time the agent will wait to respond after the user seems to be done<br/>
        ///  speaking. Increasing this value will make the agent less eager to respond, which may increase<br/>
        ///  perceived response latency but will also make the agent less likely to jump in before the user<br/>
        ///  is really done speaking.<br/>
        ///  Built-in VAD currently operates on 32ms frames, so only multiples of 32ms are meaningful.<br/>
        ///  (Anything from 1ms to 31ms will produce the same result.)<br/>
        ///  Defaults to "0.384s" (384ms) as a starting point, but there's nothing special about this value<br/>
        ///  aside from it corresponding to 12 VAD frames.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("turnEndpointDelay")]
        public string? TurnEndpointDelay { get; set; }

        /// <summary>
        /// The minimum duration of user speech required to be considered a user turn.<br/>
        ///  Increasing this value will cause the agent to ignore short user audio. This may be useful in<br/>
        ///  particularly noisy environments, but it comes at the cost of possibly ignoring very short<br/>
        ///  user responses such as "yes" or "no".<br/>
        ///  Defaults to "0s" meaning the agent considers all user audio inputs (that make it through<br/>
        ///  built-in noise cancellation).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minimumTurnDuration")]
        public string? MinimumTurnDuration { get; set; }

        /// <summary>
        /// The minimum duration of user speech required to interrupt the agent. This works the same way<br/>
        ///  as minimumTurnDuration, but allows for a higher threshold for interrupting the agent. (This<br/>
        ///  value will be ignored if it is less than minimumTurnDuration.)<br/>
        ///  Defaults to "0.09s" (90ms) as a starting point, but there's nothing special about this value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minimumInterruptionDuration")]
        public string? MinimumInterruptionDuration { get; set; }

        /// <summary>
        /// The threshold for the VAD to consider a frame as speech. This is a value between 0.1 and 1.<br/>
        ///  Miniumum value is 0.1, which is the default value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frameActivationThreshold")]
        public float? FrameActivationThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1VadSettings" /> class.
        /// </summary>
        /// <param name="turnEndpointDelay">
        /// The minimum amount of time the agent will wait to respond after the user seems to be done<br/>
        ///  speaking. Increasing this value will make the agent less eager to respond, which may increase<br/>
        ///  perceived response latency but will also make the agent less likely to jump in before the user<br/>
        ///  is really done speaking.<br/>
        ///  Built-in VAD currently operates on 32ms frames, so only multiples of 32ms are meaningful.<br/>
        ///  (Anything from 1ms to 31ms will produce the same result.)<br/>
        ///  Defaults to "0.384s" (384ms) as a starting point, but there's nothing special about this value<br/>
        ///  aside from it corresponding to 12 VAD frames.
        /// </param>
        /// <param name="minimumTurnDuration">
        /// The minimum duration of user speech required to be considered a user turn.<br/>
        ///  Increasing this value will cause the agent to ignore short user audio. This may be useful in<br/>
        ///  particularly noisy environments, but it comes at the cost of possibly ignoring very short<br/>
        ///  user responses such as "yes" or "no".<br/>
        ///  Defaults to "0s" meaning the agent considers all user audio inputs (that make it through<br/>
        ///  built-in noise cancellation).
        /// </param>
        /// <param name="minimumInterruptionDuration">
        /// The minimum duration of user speech required to interrupt the agent. This works the same way<br/>
        ///  as minimumTurnDuration, but allows for a higher threshold for interrupting the agent. (This<br/>
        ///  value will be ignored if it is less than minimumTurnDuration.)<br/>
        ///  Defaults to "0.09s" (90ms) as a starting point, but there's nothing special about this value.
        /// </param>
        /// <param name="frameActivationThreshold">
        /// The threshold for the VAD to consider a frame as speech. This is a value between 0.1 and 1.<br/>
        ///  Miniumum value is 0.1, which is the default value.
        /// </param>
        public UltravoxV1VadSettings(
            string? turnEndpointDelay,
            string? minimumTurnDuration,
            string? minimumInterruptionDuration,
            float? frameActivationThreshold)
        {
            this.TurnEndpointDelay = turnEndpointDelay;
            this.MinimumTurnDuration = minimumTurnDuration;
            this.MinimumInterruptionDuration = minimumInterruptionDuration;
            this.FrameActivationThreshold = frameActivationThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1VadSettings" /> class.
        /// </summary>
        public UltravoxV1VadSettings()
        {
        }
    }
}