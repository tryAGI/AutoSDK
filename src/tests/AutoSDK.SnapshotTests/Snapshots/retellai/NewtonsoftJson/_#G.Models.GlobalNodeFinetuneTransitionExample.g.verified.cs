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
        [global::Newtonsoft.Json.JsonProperty("transcript", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FinetuneExampleUtterance> Transcript { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalNodeFinetuneTransitionExample" /> class.
        /// </summary>
        /// <param name="transcript">
        /// Find tune the transition condition to this global node
        /// </param>
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