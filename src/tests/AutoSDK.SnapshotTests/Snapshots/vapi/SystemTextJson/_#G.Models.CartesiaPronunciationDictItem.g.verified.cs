//HintName: G.Models.CartesiaPronunciationDictItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CartesiaPronunciationDictItem
    {
        /// <summary>
        /// The text to be replaced in pronunciation<br/>
        /// Example: Vapi
        /// </summary>
        /// <example>Vapi</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The pronunciation alias or IPA representation<br/>
        /// Can be a "sounds-like" guidance (e.g., "VAH-pee") or IPA notation (e.g., "&lt;&lt;ˈ|v|ɑ|ˈ|p|i&gt;&gt;")<br/>
        /// Example: VAH-pee
        /// </summary>
        /// <example>VAH-pee</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Alias { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CartesiaPronunciationDictItem" /> class.
        /// </summary>
        /// <param name="text">
        /// The text to be replaced in pronunciation<br/>
        /// Example: Vapi
        /// </param>
        /// <param name="alias">
        /// The pronunciation alias or IPA representation<br/>
        /// Can be a "sounds-like" guidance (e.g., "VAH-pee") or IPA notation (e.g., "&lt;&lt;ˈ|v|ɑ|ˈ|p|i&gt;&gt;")<br/>
        /// Example: VAH-pee
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CartesiaPronunciationDictItem(
            string text,
            string alias)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CartesiaPronunciationDictItem" /> class.
        /// </summary>
        public CartesiaPronunciationDictItem()
        {
        }
    }
}