//HintName: G.Models.SandboxesWithMetrics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesWithMetrics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Sandboxes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesWithMetrics" /> class.
        /// </summary>
        /// <param name="sandboxes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesWithMetrics(
            object sandboxes)
        {
            this.Sandboxes = sandboxes ?? throw new global::System.ArgumentNullException(nameof(sandboxes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesWithMetrics" /> class.
        /// </summary>
        public SandboxesWithMetrics()
        {
        }
    }
}