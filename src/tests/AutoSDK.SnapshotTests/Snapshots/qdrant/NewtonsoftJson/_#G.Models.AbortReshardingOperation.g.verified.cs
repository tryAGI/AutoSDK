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
        [global::Newtonsoft.Json.JsonProperty("abort_resharding", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AbortResharding AbortResharding { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AbortReshardingOperation" /> class.
        /// </summary>
        /// <param name="abortResharding"></param>
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