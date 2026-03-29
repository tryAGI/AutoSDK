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
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public int? Speaker { get; set; }

        /// <summary>
        /// Array of transcript elements
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elements")]
        public global::System.Collections.Generic.IList<global::G.TranscriptElement>? Elements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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