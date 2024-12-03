//HintName: G.Models.CompletionChoicesDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionChoicesDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FinishReasonJsonConverter))]
        public global::G.FinishReason? FinishReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public global::G.LogprobsPart? Logprobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Example: The capital of France is Paris. It's located in the north-central part of the country and is one of the most populous and visited cities in the world, known for its iconic landmarks like the Eiffel Tower, Louvre Museum, Notre-Dame Cathedral, and more. Paris is also the capital of the Île-de-France region and is a major global center for art, fashion, gastronomy, and culture.
        /// </summary>
        /// <example>The capital of France is Paris. It's located in the north-central part of the country and is one of the most populous and visited cities in the world, known for its iconic landmarks like the Eiffel Tower, Louvre Museum, Notre-Dame Cathedral, and more. Paris is also the capital of the Île-de-France region and is a major global center for art, fashion, gastronomy, and culture.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionChoicesDataItem" /> class.
        /// </summary>
        /// <param name="finishReason"></param>
        /// <param name="logprobs"></param>
        /// <param name="seed"></param>
        /// <param name="text">
        /// Example: The capital of France is Paris. It's located in the north-central part of the country and is one of the most populous and visited cities in the world, known for its iconic landmarks like the Eiffel Tower, Louvre Museum, Notre-Dame Cathedral, and more. Paris is also the capital of the Île-de-France region and is a major global center for art, fashion, gastronomy, and culture.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CompletionChoicesDataItem(
            global::G.FinishReason? finishReason,
            global::G.LogprobsPart? logprobs,
            int? seed,
            string? text)
        {
            this.FinishReason = finishReason;
            this.Logprobs = logprobs;
            this.Seed = seed;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionChoicesDataItem" /> class.
        /// </summary>
        public CompletionChoicesDataItem()
        {
        }
    }
}