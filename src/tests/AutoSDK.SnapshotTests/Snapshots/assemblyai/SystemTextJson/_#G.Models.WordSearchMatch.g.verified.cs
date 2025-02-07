//HintName: G.Models.WordSearchMatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WordSearchMatch
    {
        /// <summary>
        /// The matched word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The total amount of times the word is in the transcript
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// An array of timestamps
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>> Timestamps { get; set; }

        /// <summary>
        /// An array of all index locations for that word within the `words` array of the completed transcript
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Indexes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WordSearchMatch" /> class.
        /// </summary>
        /// <param name="text">
        /// The matched word
        /// </param>
        /// <param name="count">
        /// The total amount of times the word is in the transcript
        /// </param>
        /// <param name="timestamps">
        /// An array of timestamps
        /// </param>
        /// <param name="indexes">
        /// An array of all index locations for that word within the `words` array of the completed transcript
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WordSearchMatch(
            string text,
            int count,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>> timestamps,
            global::System.Collections.Generic.IList<int> indexes)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Count = count;
            this.Timestamps = timestamps ?? throw new global::System.ArgumentNullException(nameof(timestamps));
            this.Indexes = indexes ?? throw new global::System.ArgumentNullException(nameof(indexes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WordSearchMatch" /> class.
        /// </summary>
        public WordSearchMatch()
        {
        }
    }
}