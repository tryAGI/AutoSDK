//HintName: G.Models.CreateUniversalUpscalerJobResponseUniversalUpscaler.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateUniversalUpscalerJobResponseUniversalUpscaler
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// API Credits Cost for Universal Upscaler Variation. Available for Production API Users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiCreditCost")]
        public int? ApiCreditCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUniversalUpscalerJobResponseUniversalUpscaler" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="apiCreditCost">
        /// API Credits Cost for Universal Upscaler Variation. Available for Production API Users.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateUniversalUpscalerJobResponseUniversalUpscaler(
            string? id,
            int? apiCreditCost)
        {
            this.Id = id;
            this.ApiCreditCost = apiCreditCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUniversalUpscalerJobResponseUniversalUpscaler" /> class.
        /// </summary>
        public CreateUniversalUpscalerJobResponseUniversalUpscaler()
        {
        }
    }
}