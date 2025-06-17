//HintName: G.Models.WidgetLanguagePreset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WidgetLanguagePreset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_contents")]
        public global::G.WidgetTextContents? TextContents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetLanguagePreset" /> class.
        /// </summary>
        /// <param name="textContents"></param>
        public WidgetLanguagePreset(
            global::G.WidgetTextContents? textContents)
        {
            this.TextContents = textContents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetLanguagePreset" /> class.
        /// </summary>
        public WidgetLanguagePreset()
        {
        }
    }
}