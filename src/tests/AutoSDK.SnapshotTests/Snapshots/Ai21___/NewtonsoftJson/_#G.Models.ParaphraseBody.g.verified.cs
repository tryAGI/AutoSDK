//HintName: G.Models.ParaphraseBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This class is to be used as a common class to all Studio API requests payloads
    /// </summary>
    public sealed partial class ParaphraseBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Default Value: general
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("style")]
        public global::G.StyleType? Style { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startIndex")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endIndex")]
        public int? EndIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParaphraseBody" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="style">
        /// Default Value: general
        /// </param>
        /// <param name="startIndex">
        /// Default Value: 0
        /// </param>
        /// <param name="endIndex"></param>
        public ParaphraseBody(
            string text,
            global::G.StyleType? style,
            int? startIndex,
            int? endIndex)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Style = style;
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParaphraseBody" /> class.
        /// </summary>
        public ParaphraseBody()
        {
        }
    }
}