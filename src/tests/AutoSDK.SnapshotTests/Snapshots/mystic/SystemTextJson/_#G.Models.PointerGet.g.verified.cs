//HintName: G.Models.PointerGet.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class PointerGet
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pointer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pointer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PipelineId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Locked { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PointerGet" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pointer"></param>
        /// <param name="pipelineId"></param>
        /// <param name="locked"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PointerGet(
            string id,
            string pointer,
            string pipelineId,
            bool locked)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Pointer = pointer ?? throw new global::System.ArgumentNullException(nameof(pointer));
            this.PipelineId = pipelineId ?? throw new global::System.ArgumentNullException(nameof(pipelineId));
            this.Locked = locked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PointerGet" /> class.
        /// </summary>
        public PointerGet()
        {
        }
    }
}