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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaTextContentBlockDeltaType Type { get; set; } = global::G.BetaTextContentBlockDeltaType.TextDelta;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTextContentBlockDelta" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: text_delta
        /// </param>
        /// <param name="text"></param>
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