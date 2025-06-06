﻿//HintName: G.Models.TextContentBlockDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextContentBlockDelta
    {
        /// <summary>
        /// Default Value: text_delta
        /// </summary>
        /// <default>global::G.TextContentBlockDeltaType.TextDelta</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TextContentBlockDeltaTypeJsonConverter))]
        public global::G.TextContentBlockDeltaType Type { get; set; } = global::G.TextContentBlockDeltaType.TextDelta;

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
        /// Initializes a new instance of the <see cref="TextContentBlockDelta" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: text_delta
        /// </param>
        /// <param name="text"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextContentBlockDelta(
            string text,
            global::G.TextContentBlockDeltaType type = global::G.TextContentBlockDeltaType.TextDelta)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextContentBlockDelta" /> class.
        /// </summary>
        public TextContentBlockDelta()
        {
        }
    }
}