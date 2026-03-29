//HintName: G.Models.SpeechMessageData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeechMessageData
    {
        /// <summary>
        /// Timestamp in seconds of the speech event<br/>
        /// Example: 12.56F
        /// </summary>
        /// <example>12.56F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Time { get; set; }

        /// <summary>
        /// Channel of the speech event<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Channel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechMessageData" /> class.
        /// </summary>
        /// <param name="time">
        /// Timestamp in seconds of the speech event<br/>
        /// Example: 12.56F
        /// </param>
        /// <param name="channel">
        /// Channel of the speech event<br/>
        /// Example: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechMessageData(
            double time,
            double channel)
        {
            this.Time = time;
            this.Channel = channel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechMessageData" /> class.
        /// </summary>
        public SpeechMessageData()
        {
        }
    }
}