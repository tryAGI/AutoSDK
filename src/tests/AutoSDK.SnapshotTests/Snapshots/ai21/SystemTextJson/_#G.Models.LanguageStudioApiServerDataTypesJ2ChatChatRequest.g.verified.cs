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
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChatMessage> Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string System { get; set; }

        /// <summary>
        /// Default Value: {"scale":0.0,"applyToWhitespaces":true,"applyToPunctuations":true,"applyToNumbers":true,"applyToStopwords":true,"applyToEmojis":true}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequencyPenalty")]
        public global::G.Penalty? FrequencyPenalty { get; set; }

        /// <summary>
        /// Default Value: {"scale":0.0,"applyToWhitespaces":true,"applyToPunctuations":true,"applyToNumbers":true,"applyToStopwords":true,"applyToEmojis":true}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presencePenalty")]
        public global::G.Penalty? PresencePenalty { get; set; }

        /// <summary>
        /// Default Value: {"scale":0.0,"applyToWhitespaces":true,"applyToPunctuations":true,"applyToNumbers":true,"applyToStopwords":true,"applyToEmojis":true}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("countPenalty")]
        public global::G.Penalty? CountPenalty { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numResults")]
        public int? NumResults { get; set; }

        /// <summary>
        /// Default Value: 0.7F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Default Value: 300
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxTokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minTokens")]
        public int? MinTokens { get; set; }

        /// <summary>
        /// Default Value: 1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topP")]
        public double? TopP { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topKReturn")]
        public int? TopKReturn { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopSequences")]
        public global::System.Collections.Generic.IList<string>? StopSequences { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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