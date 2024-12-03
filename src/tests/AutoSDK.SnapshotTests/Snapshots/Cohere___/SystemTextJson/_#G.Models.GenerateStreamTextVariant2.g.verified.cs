//HintName: G.Models.GenerateStreamTextVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateStreamTextVariant2
    {
        /// <summary>
        /// A segment of text of the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Refers to the nth generation. Only present when `num_generations` is greater than zero, and only when text responses are being streamed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_finished")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFinished { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateStreamTextVariant2" /> class.
        /// </summary>
        /// <param name="text">
        /// A segment of text of the generation.
        /// </param>
        /// <param name="index">
        /// Refers to the nth generation. Only present when `num_generations` is greater than zero, and only when text responses are being streamed.
        /// </param>
        /// <param name="isFinished"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GenerateStreamTextVariant2(
            string text,
            bool isFinished,
            int? index)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.IsFinished = isFinished;
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateStreamTextVariant2" /> class.
        /// </summary>
        public GenerateStreamTextVariant2()
        {
        }
    }
}