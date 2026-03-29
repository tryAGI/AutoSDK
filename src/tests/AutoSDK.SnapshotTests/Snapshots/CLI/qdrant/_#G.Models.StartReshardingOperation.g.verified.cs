//HintName: G.Models.StartReshardingOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartReshardingOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_resharding")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.StartResharding StartResharding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartReshardingOperation" /> class.
        /// </summary>
        /// <param name="startResharding"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartReshardingOperation(
            global::G.StartResharding startResharding)
        {
            this.StartResharding = startResharding ?? throw new global::System.ArgumentNullException(nameof(startResharding));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartReshardingOperation" /> class.
        /// </summary>
        public StartReshardingOperation()
        {
        }
    }
}