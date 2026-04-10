//HintName: G.Models.WidgetEndFeedbackConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WidgetEndFeedbackConfig
    {
        /// <summary>
        /// The type of feedback to collect at the end of the conversation<br/>
        /// Default Value: rating
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WidgetEndFeedbackTypeJsonConverter))]
        public global::G.WidgetEndFeedbackType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetEndFeedbackConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of feedback to collect at the end of the conversation<br/>
        /// Default Value: rating
        /// </param>
        public WidgetEndFeedbackConfig(
            global::G.WidgetEndFeedbackType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetEndFeedbackConfig" /> class.
        /// </summary>
        public WidgetEndFeedbackConfig()
        {
        }
    }
}