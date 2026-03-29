//HintName: G.Models.Transcript.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Rev.ai Transcript
    /// </summary>
    public sealed partial class Transcript
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monologues")]
        public global::System.Collections.Generic.IList<global::G.Monologue>? Monologues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Transcript" /> class.
        /// </summary>
        /// <param name="monologues"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Transcript(
            global::System.Collections.Generic.IList<global::G.Monologue>? monologues)
        {
            this.Monologues = monologues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transcript" /> class.
        /// </summary>
        public Transcript()
        {
        }
    }
}