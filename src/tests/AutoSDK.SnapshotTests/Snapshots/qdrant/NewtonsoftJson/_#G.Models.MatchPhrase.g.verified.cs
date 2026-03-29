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
        [global::Newtonsoft.Json.JsonProperty("phrase", Required = global::Newtonsoft.Json.Required.Always)]
        public string Phrase { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchPhrase" /> class.
        /// </summary>
        /// <param name="phrase"></param>
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