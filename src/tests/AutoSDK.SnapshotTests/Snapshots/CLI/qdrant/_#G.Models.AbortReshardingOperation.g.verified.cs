//HintName: G.Models.AbortReshardingOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AbortReshardingOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("abort_resharding")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AbortResharding AbortResharding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AbortReshardingOperation" /> class.
        /// </summary>
        /// <param name="abortResharding"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AbortReshardingOperation(
            global::G.AbortResharding abortResharding)
        {
            this.AbortResharding = abortResharding ?? throw new global::System.ArgumentNullException(nameof(abortResharding));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbortReshardingOperation" /> class.
        /// </summary>
        public AbortReshardingOperation()
        {
        }
    }
}