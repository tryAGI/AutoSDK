//HintName: G.Models.PerformAlchemyUpscaleLCMResponseLcmGenerationJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PerformAlchemyUpscaleLCMResponseLcmGenerationJob
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("imageDataUrl")]
        public global::System.Collections.Generic.IList<string>? ImageDataUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generationId")]
        public global::System.Collections.Generic.IList<string>? GenerationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variationId")]
        public global::System.Collections.Generic.IList<string>? VariationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generatedImageId")]
        public string? GeneratedImageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requestTimestamp")]
        public string? RequestTimestamp { get; set; }

        /// <summary>
        /// API credits cost, available for Production API users.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiCreditCost")]
        public int? ApiCreditCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformAlchemyUpscaleLCMResponseLcmGenerationJob" /> class.
        /// </summary>
        /// <param name="imageDataUrl"></param>
        /// <param name="generationId"></param>
        /// <param name="variationId"></param>
        /// <param name="generatedImageId"></param>
        /// <param name="requestTimestamp"></param>
        /// <param name="apiCreditCost">
        /// API credits cost, available for Production API users.
        /// </param>
        public PerformAlchemyUpscaleLCMResponseLcmGenerationJob(
            global::System.Collections.Generic.IList<string>? imageDataUrl,
            global::System.Collections.Generic.IList<string>? generationId,
            global::System.Collections.Generic.IList<string>? variationId,
            string? generatedImageId,
            string? requestTimestamp,
            int? apiCreditCost)
        {
            this.ImageDataUrl = imageDataUrl;
            this.GenerationId = generationId;
            this.VariationId = variationId;
            this.GeneratedImageId = generatedImageId;
            this.RequestTimestamp = requestTimestamp;
            this.ApiCreditCost = apiCreditCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformAlchemyUpscaleLCMResponseLcmGenerationJob" /> class.
        /// </summary>
        public PerformAlchemyUpscaleLCMResponseLcmGenerationJob()
        {
        }
    }
}