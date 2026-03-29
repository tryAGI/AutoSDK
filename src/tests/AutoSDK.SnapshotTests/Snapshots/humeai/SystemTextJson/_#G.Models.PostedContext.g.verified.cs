//HintName: G.Models.PostedContext.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostedContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        public string? GenerationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utterances")]
        public global::System.Collections.Generic.IList<global::G.PostedUtterance>? Utterances { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedContext" /> class.
        /// </summary>
        /// <param name="generationId"></param>
        /// <param name="utterances"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostedContext(
            string? generationId,
            global::System.Collections.Generic.IList<global::G.PostedUtterance>? utterances)
        {
            this.GenerationId = generationId;
            this.Utterances = utterances;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedContext" /> class.
        /// </summary>
        public PostedContext()
        {
        }
    }
}