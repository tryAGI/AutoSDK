//HintName: G.Models.MatchText.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Full-text match of the strings.
    /// </summary>
    public sealed partial class MatchText
    {
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
        /// Initializes a new instance of the <see cref="MatchText" /> class.
        /// </summary>
        /// <param name="text"></param>
        public MatchText(
            string text)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchText" /> class.
        /// </summary>
        public MatchText()
        {
        }
    }
}