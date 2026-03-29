//HintName: G.Models.Monologue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Monologue
    {
        /// <summary>
        /// Speaker ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speaker")]
        public int? Speaker { get; set; }

        /// <summary>
        /// Array of transcript elements
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("elements")]
        public global::System.Collections.Generic.IList<global::G.TranscriptElement>? Elements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Monologue" /> class.
        /// </summary>
        /// <param name="speaker">
        /// Speaker ID
        /// </param>
        /// <param name="elements">
        /// Array of transcript elements
        /// </param>
        public Monologue(
            int? speaker,
            global::System.Collections.Generic.IList<global::G.TranscriptElement>? elements)
        {
            this.Speaker = speaker;
            this.Elements = elements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Monologue" /> class.
        /// </summary>
        public Monologue()
        {
        }
    }
}