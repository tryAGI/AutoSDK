//HintName: G.Models.CreateGenerationResponseSdGenerationJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGenerationResponseSdGenerationJob
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generationId")]
        public string? GenerationId { get; set; }

        /// <summary>
        /// API Credits Cost for Image Generation. Available for Production API Users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiCreditCost")]
        public int? ApiCreditCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerationResponseSdGenerationJob" /> class.
        /// </summary>
        /// <param name="generationId"></param>
        /// <param name="apiCreditCost">
        /// API Credits Cost for Image Generation. Available for Production API Users.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateGenerationResponseSdGenerationJob(
            string? generationId,
            int? apiCreditCost)
        {
            this.GenerationId = generationId;
            this.ApiCreditCost = apiCreditCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerationResponseSdGenerationJob" /> class.
        /// </summary>
        public CreateGenerationResponseSdGenerationJob()
        {
        }
    }
}