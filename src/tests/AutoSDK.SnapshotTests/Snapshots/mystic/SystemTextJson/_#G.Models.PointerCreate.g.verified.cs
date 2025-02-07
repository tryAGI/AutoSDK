//HintName: G.Models.PointerCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class PointerCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pointer_or_pipeline_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PointerOrPipelineId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pointer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pointer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locked")]
        public bool? Locked { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PointerCreate" /> class.
        /// </summary>
        /// <param name="pointerOrPipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="locked"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PointerCreate(
            string pointerOrPipelineId,
            string pointer,
            bool? locked)
        {
            this.PointerOrPipelineId = pointerOrPipelineId ?? throw new global::System.ArgumentNullException(nameof(pointerOrPipelineId));
            this.Pointer = pointer ?? throw new global::System.ArgumentNullException(nameof(pointer));
            this.Locked = locked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PointerCreate" /> class.
        /// </summary>
        public PointerCreate()
        {
        }
    }
}