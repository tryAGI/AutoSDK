//HintName: G.Models.LanguageStudioApiServerDataTypesJ2ChatChatRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This class is to be used as a common class to all Studio API requests payloads
    /// </summary>
    public sealed partial class LanguageStudioApiServerDataTypesJ2ChatChatRequest
    {
        /// <summary>
        /// messages
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChatMessage> Messages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system", Required = global::Newtonsoft.Json.Required.Always)]
        public string System { get; set; } = default!;

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
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("numResults")]
        public int? NumResults { get; set; }

        /// <summary>
        /// Default Value: 0.7F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Default Value: 300
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
        [global::Newtonsoft.Json.JsonProperty("topP")]
        public double? TopP { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topKReturn")]
        public int? TopKReturn { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stopSequences")]
        public global::System.Collections.Generic.IList<string>? StopSequences { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageStudioApiServerDataTypesJ2ChatChatRequest" /> class.
        /// </summary>
        /// <param name="messages">
        /// messages
        /// </param>
        /// <param name="system"></param>
        /// <param name="frequencyPenalty">
        /// Default Value: {"scale":0.0,"applyToWhitespaces":true,"applyToPunctuations":true,"applyToNumbers":true,"applyToStopwords":true,"applyToEmojis":true}
        /// </param>
        /// <param name="presencePenalty">
        /// Default Value: {"scale":0.0,"applyToWhitespaces":true,"applyToPunctuations":true,"applyToNumbers":true,"applyToStopwords":true,"applyToEmojis":true}
        /// </param>
        /// <param name="countPenalty">
        /// Default Value: {"scale":0.0,"applyToWhitespaces":true,"applyToPunctuations":true,"applyToNumbers":true,"applyToStopwords":true,"applyToEmojis":true}
        /// </param>
        /// <param name="numResults">
        /// Default Value: 1
        /// </param>
        /// <param name="temperature">
        /// Default Value: 0.7F
        /// </param>
        /// <param name="maxTokens">
        /// Default Value: 300
        /// </param>
        /// <param name="minTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="topP">
        /// Default Value: 1F
        /// </param>
        /// <param name="topKReturn">
        /// Default Value: 0
        /// </param>
        /// <param name="stopSequences">
        /// Default Value: []
        /// </param>
        public LanguageStudioApiServerDataTypesJ2ChatChatRequest(
            global::System.Collections.Generic.IList<global::G.ChatMessage> messages,
            string system,
            global::G.Penalty? frequencyPenalty,
            global::G.Penalty? presencePenalty,
            global::G.Penalty? countPenalty,
            int? numResults,
            double? temperature,
            int? maxTokens,
            int? minTokens,
            double? topP,
            int? topKReturn,
            global::System.Collections.Generic.IList<string>? stopSequences)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.System = system ?? throw new global::System.ArgumentNullException(nameof(system));
            this.FrequencyPenalty = frequencyPenalty;
            this.PresencePenalty = presencePenalty;
            this.CountPenalty = countPenalty;
            this.NumResults = numResults;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.MinTokens = minTokens;
            this.TopP = topP;
            this.TopKReturn = topKReturn;
            this.StopSequences = stopSequences;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageStudioApiServerDataTypesJ2ChatChatRequest" /> class.
        /// </summary>
        public LanguageStudioApiServerDataTypesJ2ChatChatRequest()
        {
        }
    }
}