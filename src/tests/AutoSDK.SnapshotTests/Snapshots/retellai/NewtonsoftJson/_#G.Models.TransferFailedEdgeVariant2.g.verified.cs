//HintName: G.Models.TransferFailedEdgeVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferFailedEdgeVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transition_condition", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TransferFailedEdgeVariant2TransitionCondition TransitionCondition { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferFailedEdgeVariant2" /> class.
        /// </summary>
        /// <param name="transitionCondition"></param>
        public TransferFailedEdgeVariant2(
            global::G.TransferFailedEdgeVariant2TransitionCondition transitionCondition)
        {
            this.TransitionCondition = transitionCondition ?? throw new global::System.ArgumentNullException(nameof(transitionCondition));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferFailedEdgeVariant2" /> class.
        /// </summary>
        public TransferFailedEdgeVariant2()
        {
        }
    }
}