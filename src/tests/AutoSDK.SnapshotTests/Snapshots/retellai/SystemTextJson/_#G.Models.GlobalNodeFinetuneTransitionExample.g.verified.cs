//HintName: G.Models.GlobalNodeFinetuneTransitionExample.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GlobalNodeFinetuneTransitionExample
    {
        /// <summary>
        /// Find tune the transition condition to this global node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.FinetuneExampleUtterance> Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalNodeFinetuneTransitionExample" /> class.
        /// </summary>
        /// <param name="transcript">
        /// Find tune the transition condition to this global node
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GlobalNodeFinetuneTransitionExample(
            global::System.Collections.Generic.IList<global::G.FinetuneExampleUtterance> transcript)
        {
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalNodeFinetuneTransitionExample" /> class.
        /// </summary>
        public GlobalNodeFinetuneTransitionExample()
        {
        }
    }
}