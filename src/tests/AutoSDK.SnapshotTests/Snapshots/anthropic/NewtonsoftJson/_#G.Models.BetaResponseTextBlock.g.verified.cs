//HintName: G.Models.BetaResponseTextBlock.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseTextBlock
    {
        /// <summary>
        /// Default Value: text
        /// </summary>
        /// <default>global::G.BetaResponseTextBlockType.Text</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaResponseTextBlockType Type { get; set; } = global::G.BetaResponseTextBlockType.Text;

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
        /// Initializes a new instance of the <see cref="BetaResponseTextBlock" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: text
        /// </param>
        /// <param name="text"></param>
        public BetaResponseTextBlock(
            string text,
            global::G.BetaResponseTextBlockType type = global::G.BetaResponseTextBlockType.Text)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseTextBlock" /> class.
        /// </summary>
        public BetaResponseTextBlock()
        {
        }
    }
}