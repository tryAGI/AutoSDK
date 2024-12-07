//HintName: G.Models.BetaTextContentBlockDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaTextContentBlockDelta
    {
        /// <summary>
        /// Default Value: text_delta
        /// </summary>
        /// <default>global::G.BetaTextContentBlockDeltaType.TextDelta</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BetaTextContentBlockDeltaTypeJsonConverter))]
        public global::G.BetaTextContentBlockDeltaType Type { get; set; } = global::G.BetaTextContentBlockDeltaType.TextDelta;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTextContentBlockDelta" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: text_delta
        /// </param>
        /// <param name="text"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BetaTextContentBlockDelta(
            string text,
            global::G.BetaTextContentBlockDeltaType type = global::G.BetaTextContentBlockDeltaType.TextDelta)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTextContentBlockDelta" /> class.
        /// </summary>
        public BetaTextContentBlockDelta()
        {
        }
    }
}