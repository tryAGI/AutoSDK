//HintName: G.Models.WidgetLanguagePresetResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WidgetLanguagePresetResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        public string? FirstMessage { get; set; }

        /// <summary>
        /// The text contents for the selected language
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_contents")]
        public global::G.WidgetTextContents? TextContents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetLanguagePresetResponse" /> class.
        /// </summary>
        /// <param name="firstMessage"></param>
        /// <param name="textContents">
        /// The text contents for the selected language
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WidgetLanguagePresetResponse(
            string? firstMessage,
            global::G.WidgetTextContents? textContents)
        {
            this.FirstMessage = firstMessage;
            this.TextContents = textContents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetLanguagePresetResponse" /> class.
        /// </summary>
        public WidgetLanguagePresetResponse()
        {
        }
    }
}