//HintName: G.Models.GenerateStreamTextYai5v6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateStreamTextYai5v6
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
        /// Initializes a new instance of the <see cref="GenerateStreamTextYai5v6" /> class.
        /// </summary>
        /// <param name="text">
        /// A segment of text of the generation.
        /// </param>
        /// <param name="isFinished"></param>
        /// <param name="index">
        /// Refers to the nth generation. Only present when `num_generations` is greater than zero, and only when text responses are being streamed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateStreamTextYai5v6(
            string text,
            bool isFinished,
            int? index)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Index = index;
            this.IsFinished = isFinished;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateStreamTextYai5v6" /> class.
        /// </summary>
        public GenerateStreamTextYai5v6()
        {
        }
    }
}