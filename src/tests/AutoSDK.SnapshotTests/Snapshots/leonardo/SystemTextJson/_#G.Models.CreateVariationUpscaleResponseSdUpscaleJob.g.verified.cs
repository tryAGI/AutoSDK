//HintName: G.Models.CreateVariationUpscaleResponseSdUpscaleJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVariationUpscaleResponseSdUpscaleJob
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// API Credits Cost for Upscale Variation. Available for Production API Users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiCreditCost")]
        public int? ApiCreditCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVariationUpscaleResponseSdUpscaleJob" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="apiCreditCost">
        /// API Credits Cost for Upscale Variation. Available for Production API Users.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVariationUpscaleResponseSdUpscaleJob(
            string? id,
            int? apiCreditCost)
        {
            this.Id = id;
            this.ApiCreditCost = apiCreditCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVariationUpscaleResponseSdUpscaleJob" /> class.
        /// </summary>
        public CreateVariationUpscaleResponseSdUpscaleJob()
        {
        }
    }
}