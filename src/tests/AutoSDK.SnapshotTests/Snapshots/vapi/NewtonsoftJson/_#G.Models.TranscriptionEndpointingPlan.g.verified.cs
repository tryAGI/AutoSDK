//HintName: G.Models.TranscriptionEndpointingPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptionEndpointingPlan
    {
        /// <summary>
        /// The minimum number of seconds to wait after transcription ending with punctuation before sending a request to the model. Defaults to 0.1.<br/>
        /// This setting exists because the transcriber punctuates the transcription when it's more confident that customer has completed a thought.<br/>
        /// @default 0.1<br/>
        /// Example: 0.1F
        /// </summary>
        /// <example>0.1F</example>
        [global::Newtonsoft.Json.JsonProperty("onPunctuationSeconds")]
        public double? OnPunctuationSeconds { get; set; }

        /// <summary>
        /// The minimum number of seconds to wait after transcription ending without punctuation before sending a request to the model. Defaults to 1.5.<br/>
        /// This setting exists to catch the cases where the transcriber was not confident enough to punctuate the transcription, but the customer is done and has been silent for a long time.<br/>
        /// @default 1.5<br/>
        /// Example: 1.5F
        /// </summary>
        /// <example>1.5F</example>
        [global::Newtonsoft.Json.JsonProperty("onNoPunctuationSeconds")]
        public double? OnNoPunctuationSeconds { get; set; }

        /// <summary>
        /// The minimum number of seconds to wait after transcription ending with a number before sending a request to the model. Defaults to 0.4.<br/>
        /// This setting exists because the transcriber will sometimes punctuate the transcription ending with a number, even though the customer hasn't uttered the full number. This happens commonly for long numbers when the customer reads the number in chunks.<br/>
        /// @default 0.5<br/>
        /// Example: 0.5F
        /// </summary>
        /// <example>0.5F</example>
        [global::Newtonsoft.Json.JsonProperty("onNumberSeconds")]
        public double? OnNumberSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionEndpointingPlan" /> class.
        /// </summary>
        /// <param name="onPunctuationSeconds">
        /// The minimum number of seconds to wait after transcription ending with punctuation before sending a request to the model. Defaults to 0.1.<br/>
        /// This setting exists because the transcriber punctuates the transcription when it's more confident that customer has completed a thought.<br/>
        /// @default 0.1<br/>
        /// Example: 0.1F
        /// </param>
        /// <param name="onNoPunctuationSeconds">
        /// The minimum number of seconds to wait after transcription ending without punctuation before sending a request to the model. Defaults to 1.5.<br/>
        /// This setting exists to catch the cases where the transcriber was not confident enough to punctuate the transcription, but the customer is done and has been silent for a long time.<br/>
        /// @default 1.5<br/>
        /// Example: 1.5F
        /// </param>
        /// <param name="onNumberSeconds">
        /// The minimum number of seconds to wait after transcription ending with a number before sending a request to the model. Defaults to 0.4.<br/>
        /// This setting exists because the transcriber will sometimes punctuate the transcription ending with a number, even though the customer hasn't uttered the full number. This happens commonly for long numbers when the customer reads the number in chunks.<br/>
        /// @default 0.5<br/>
        /// Example: 0.5F
        /// </param>
        public TranscriptionEndpointingPlan(
            double? onPunctuationSeconds,
            double? onNoPunctuationSeconds,
            double? onNumberSeconds)
        {
            this.OnPunctuationSeconds = onPunctuationSeconds;
            this.OnNoPunctuationSeconds = onNoPunctuationSeconds;
            this.OnNumberSeconds = onNumberSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionEndpointingPlan" /> class.
        /// </summary>
        public TranscriptionEndpointingPlan()
        {
        }
    }
}