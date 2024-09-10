//HintName: G.Models.CompletionBody.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

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
        public int NumResults { get; set; } = 1;

        /// <summary>
        /// Default Value: 16
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxTokens")]
        public int MaxTokens { get; set; } = 16;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minTokens")]
        public int MinTokens { get; set; } = 0;

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double Temperature { get; set; } = 1;

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topP")]
        public double TopP { get; set; } = 1;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minP")]
        public double MinP { get; set; } = 0;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stopSequences")]
        public global::System.Collections.Generic.IList<string>? StopSequences { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topKReturn")]
        public int TopKReturn { get; set; } = 0;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logitBias")]
        public global::G.CompletionBodyLogitBias? LogitBias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frequencyPenalty")]
        public global::G.AllOf<global::G.Penalty>? FrequencyPenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presencePenalty")]
        public global::G.AllOf<global::G.Penalty>? PresencePenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("countPenalty")]
        public global::G.AllOf<global::G.Penalty>? CountPenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("epoch")]
        public int Epoch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}