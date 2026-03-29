//HintName: G.Models.MatchPhrase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Full-text phrase match of the string.
    /// </summary>
    public sealed partial class MatchPhrase
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phrase")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Phrase { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchPhrase" /> class.
        /// </summary>
        /// <param name="phrase"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MatchPhrase(
            string phrase)
        {
            this.Phrase = phrase ?? throw new global::System.ArgumentNullException(nameof(phrase));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchPhrase" /> class.
        /// </summary>
        public MatchPhrase()
        {
        }
    }
}