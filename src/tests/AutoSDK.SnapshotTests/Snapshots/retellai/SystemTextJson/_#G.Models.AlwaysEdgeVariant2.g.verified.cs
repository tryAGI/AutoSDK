//HintName: G.Models.AlwaysEdgeVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlwaysEdgeVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transition_condition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AlwaysEdgeVariant2TransitionCondition TransitionCondition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlwaysEdgeVariant2" /> class.
        /// </summary>
        /// <param name="transitionCondition"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlwaysEdgeVariant2(
            global::G.AlwaysEdgeVariant2TransitionCondition transitionCondition)
        {
            this.TransitionCondition = transitionCondition ?? throw new global::System.ArgumentNullException(nameof(transitionCondition));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlwaysEdgeVariant2" /> class.
        /// </summary>
        public AlwaysEdgeVariant2()
        {
        }
    }
}