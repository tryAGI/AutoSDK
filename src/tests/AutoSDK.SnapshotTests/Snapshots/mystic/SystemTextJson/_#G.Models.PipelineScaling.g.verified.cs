//HintName: G.Models.PipelineScaling.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class PipelineScaling
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("desired")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Desired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Current { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineScaling" /> class.
        /// </summary>
        /// <param name="desired"></param>
        /// <param name="current"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelineScaling(
            int desired,
            int current)
        {
            this.Desired = desired;
            this.Current = current;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineScaling" /> class.
        /// </summary>
        public PipelineScaling()
        {
        }
    }
}