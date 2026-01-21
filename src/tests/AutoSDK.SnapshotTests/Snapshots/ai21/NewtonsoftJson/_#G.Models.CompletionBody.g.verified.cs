//HintName: G.Models.CompletionBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("numResults")]
        public int? NumResults { get; set; }

        /// <summary>
        /// Default Value: 16
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxTokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minTokens")]
        public int? MinTokens { get; set; }

        /// <summary>
        /// Default Value: 1F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Default Value: 1F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topP")]
        public double? TopP { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minP")]
        public double? MinP { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stopSequences")]
        public global::System.Collections.Generic.IList<string>? StopSequences { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topKReturn")]
        public int? TopKReturn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logitBias")]
        public object? LogitBias { get; set; }

        /// <summary>
        /// Default Value: {"scale":0.0,"applyToWhitespaces":true,"applyToPunctuations":true,"applyToNumbers":true,"applyToStopwords":true,"applyToEmojis":true}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frequencyPenalty")]
        public global::G.Penalty? FrequencyPenalty { get; set; }

        /// <summary>
        /// Default Value: {"scale":0.0,"applyToWhitespaces":true,"applyToPunctuations":true,"applyToNumbers":true,"applyToStopwords":true,"applyToEmojis":true}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presencePenalty")]
        public global::G.Penalty? PresencePenalty { get; set; }

        /// <summary>
        /// Default Value: {"scale":0.0,"applyToWhitespaces":true,"applyToPunctuations":true,"applyToNumbers":true,"applyToStopwords":true,"applyToEmojis":true}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("countPenalty")]
        public global::G.Penalty? CountPenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("epoch")]
        public int? Epoch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionBody" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="numResults">
        /// Default Value: 1
        /// </param>
        /// <param name="maxTokens">
        /// Default Value: 16
        /// </param>
        /// <param name="minTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="temperature">
        /// Default Value: 1F
        /// </param>
        /// <param name="topP">
        /// Default Value: 1F
        /// </param>
        /// <param name="minP">
        /// Default Value: 0F
        /// </param>
        /// <param name="stopSequences">
        /// Default Value: []
        /// </param>
        /// <param name="topKReturn">
        /// Default Value: 0
        /// </param>
        /// <param name="logitBias"></param>
        /// <param name="frequencyPenalty">
        /// Default Value: {"scale":0.0,"applyToWhitespaces":true,"applyToPunctuations":true,"applyToNumbers":true,"applyToStopwords":true,"applyToEmojis":true}
        /// </param>
        /// <param name="presencePenalty">
        /// Default Value: {"scale":0.0,"applyToWhitespaces":true,"applyToPunctuations":true,"applyToNumbers":true,"applyToStopwords":true,"applyToEmojis":true}
        /// </param>
        /// <param name="countPenalty">
        /// Default Value: {"scale":0.0,"applyToWhitespaces":true,"applyToPunctuations":true,"applyToNumbers":true,"applyToStopwords":true,"applyToEmojis":true}
        /// </param>
        /// <param name="epoch"></param>
        public CompletionBody(
            string prompt,
            int? numResults,
            int? maxTokens,
            int? minTokens,
            double? temperature,
            double? topP,
            double? minP,
            global::System.Collections.Generic.IList<string>? stopSequences,
            int? topKReturn,
            object? logitBias,
            global::G.Penalty? frequencyPenalty,
            global::G.Penalty? presencePenalty,
            global::G.Penalty? countPenalty,
            int? epoch)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.NumResults = numResults;
            this.MaxTokens = maxTokens;
            this.MinTokens = minTokens;
            this.Temperature = temperature;
            this.TopP = topP;
            this.MinP = minP;
            this.StopSequences = stopSequences;
            this.TopKReturn = topKReturn;
            this.LogitBias = logitBias;
            this.FrequencyPenalty = frequencyPenalty;
            this.PresencePenalty = presencePenalty;
            this.CountPenalty = countPenalty;
            this.Epoch = epoch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionBody" /> class.
        /// </summary>
        public CompletionBody()
        {
        }
    }
}