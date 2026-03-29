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
        [global::Newtonsoft.Json.JsonProperty("time", Required = global::Newtonsoft.Json.Required.Always)]
        public double Time { get; set; } = default!;

        /// <summary>
        /// Channel of the speech event<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("channel", Required = global::Newtonsoft.Json.Required.Always)]
        public double Channel { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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