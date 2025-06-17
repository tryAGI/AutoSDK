//HintName: G.Models.TurnConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TurnConfig
    {
        /// <summary>
        /// Maximum wait time for the user's reply before re-engaging the user<br/>
        /// Default Value: 7
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_timeout")]
        public double? TurnTimeout { get; set; }

        /// <summary>
        /// Maximum wait time since the user last spoke before terminating the call<br/>
        /// Default Value: -1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("silence_end_call_timeout")]
        public double? SilenceEndCallTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TurnModeJsonConverter))]
        public global::G.TurnMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnConfig" /> class.
        /// </summary>
        /// <param name="turnTimeout">
        /// Maximum wait time for the user's reply before re-engaging the user<br/>
        /// Default Value: 7
        /// </param>
        /// <param name="silenceEndCallTimeout">
        /// Maximum wait time since the user last spoke before terminating the call<br/>
        /// Default Value: -1
        /// </param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TurnConfig(
            double? turnTimeout,
            double? silenceEndCallTimeout,
            global::G.TurnMode? mode)
        {
            this.TurnTimeout = turnTimeout;
            this.SilenceEndCallTimeout = silenceEndCallTimeout;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnConfig" /> class.
        /// </summary>
        public TurnConfig()
        {
        }
    }
}