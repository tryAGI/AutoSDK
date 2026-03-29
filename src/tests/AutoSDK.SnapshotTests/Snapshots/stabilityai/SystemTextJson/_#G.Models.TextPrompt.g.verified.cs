//HintName: G.Models.TextPrompt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Text prompt for image generation
    /// </summary>
    public sealed partial class TextPrompt
    {
        /// <summary>
        /// The prompt itself<br/>
        /// Example: A lighthouse on a cliff
        /// </summary>
        /// <example>A lighthouse on a cliff</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Weight of the prompt (use negative numbers for negative prompts)<br/>
        /// Example: 0.8167237F
        /// </summary>
        /// <example>0.8167237F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public float? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextPrompt" /> class.
        /// </summary>
        /// <param name="text">
        /// The prompt itself<br/>
        /// Example: A lighthouse on a cliff
        /// </param>
        /// <param name="weight">
        /// Weight of the prompt (use negative numbers for negative prompts)<br/>
        /// Example: 0.8167237F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextPrompt(
            string text,
            float? weight)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextPrompt" /> class.
        /// </summary>
        public TextPrompt()
        {
        }
    }
}