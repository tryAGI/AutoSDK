//HintName: G.Models.QuestionAnsweringOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options for question answering.
    /// </summary>
    public sealed partial class QuestionAnsweringOptions
    {
        /// <summary>
        /// Whether to use citations<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cite")]
        public bool? Cite { get; set; }

        /// <summary>
        /// Whether to use multimodal context<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multimodal")]
        public bool? Multimodal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionAnsweringOptions" /> class.
        /// </summary>
        /// <param name="cite">
        /// Whether to use citations<br/>
        /// Default Value: true
        /// </param>
        /// <param name="multimodal">
        /// Whether to use multimodal context<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuestionAnsweringOptions(
            bool? cite,
            bool? multimodal)
        {
            this.Cite = cite;
            this.Multimodal = multimodal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionAnsweringOptions" /> class.
        /// </summary>
        public QuestionAnsweringOptions()
        {
        }
    }
}