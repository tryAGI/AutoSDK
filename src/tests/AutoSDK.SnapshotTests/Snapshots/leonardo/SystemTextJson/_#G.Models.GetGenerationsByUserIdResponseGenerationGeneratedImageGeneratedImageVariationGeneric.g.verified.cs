//HintName: G.Models.GetGenerationsByUserIdResponseGenerationGeneratedImageGeneratedImageVariationGeneric.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// columns and relationships of "generated_image_variation_generic"
    /// </summary>
    public sealed partial class GetGenerationsByUserIdResponseGenerationGeneratedImageGeneratedImageVariationGeneric
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The status of the current task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JobStatusJsonConverter))]
        public global::G.JobStatus? Status { get; set; }

        /// <summary>
        /// The type of variation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transformType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VARIATIONTYPEJsonConverter))]
        public global::G.VARIATIONTYPE? TransformType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationsByUserIdResponseGenerationGeneratedImageGeneratedImageVariationGeneric" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status">
        /// The status of the current task.
        /// </param>
        /// <param name="transformType">
        /// The type of variation.
        /// </param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetGenerationsByUserIdResponseGenerationGeneratedImageGeneratedImageVariationGeneric(
            string? id,
            global::G.JobStatus? status,
            global::G.VARIATIONTYPE? transformType,
            string? url)
        {
            this.Id = id;
            this.Status = status;
            this.TransformType = transformType;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationsByUserIdResponseGenerationGeneratedImageGeneratedImageVariationGeneric" /> class.
        /// </summary>
        public GetGenerationsByUserIdResponseGenerationGeneratedImageGeneratedImageVariationGeneric()
        {
        }
    }
}