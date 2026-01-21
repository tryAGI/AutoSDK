//HintName: G.Models.TranscriptCustomSpelling.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Object containing words or phrases to replace, and the word or phrase to replace with<br/>
    /// Example: {"from":["dicarlo"],"to":"Decarlo"}
    /// </summary>
    public sealed partial class TranscriptCustomSpelling
    {
        /// <summary>
        /// Words or phrases to replace
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> From { get; set; } = default!;

        /// <summary>
        /// Word or phrase to replace with
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to", Required = global::Newtonsoft.Json.Required.Always)]
        public string To { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptCustomSpelling" /> class.
        /// </summary>
        /// <param name="from">
        /// Words or phrases to replace
        /// </param>
        /// <param name="to">
        /// Word or phrase to replace with
        /// </param>
        public TranscriptCustomSpelling(
            global::System.Collections.Generic.IList<string> from,
            string to)
        {
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
            this.To = to ?? throw new global::System.ArgumentNullException(nameof(to));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptCustomSpelling" /> class.
        /// </summary>
        public TranscriptCustomSpelling()
        {
        }
    }
}