//HintName: G.Models.CreateLCMGenerationResponseLcmGenerationJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateLCMGenerationResponseLcmGenerationJob
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageDataUrl")]
        public global::System.Collections.Generic.IList<string>? ImageDataUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestTimestamp")]
        public string? RequestTimestamp { get; set; }

        /// <summary>
        /// API credits cost, available for Production API users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiCreditCost")]
        public int? ApiCreditCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLCMGenerationResponseLcmGenerationJob" /> class.
        /// </summary>
        /// <param name="imageDataUrl"></param>
        /// <param name="requestTimestamp"></param>
        /// <param name="apiCreditCost">
        /// API credits cost, available for Production API users.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateLCMGenerationResponseLcmGenerationJob(
            global::System.Collections.Generic.IList<string>? imageDataUrl,
            string? requestTimestamp,
            int? apiCreditCost)
        {
            this.ImageDataUrl = imageDataUrl;
            this.RequestTimestamp = requestTimestamp;
            this.ApiCreditCost = apiCreditCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLCMGenerationResponseLcmGenerationJob" /> class.
        /// </summary>
        public CreateLCMGenerationResponseLcmGenerationJob()
        {
        }
    }
}