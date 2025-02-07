//HintName: G.Models.CreateModelResponseSdTrainingJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModelResponseSdTrainingJob
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customModelId")]
        public string? CustomModelId { get; set; }

        /// <summary>
        /// API Credits Cost for Model Training. Available for Production API Users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiCreditCost")]
        public int? ApiCreditCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelResponseSdTrainingJob" /> class.
        /// </summary>
        /// <param name="customModelId"></param>
        /// <param name="apiCreditCost">
        /// API Credits Cost for Model Training. Available for Production API Users.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModelResponseSdTrainingJob(
            string? customModelId,
            int? apiCreditCost)
        {
            this.CustomModelId = customModelId;
            this.ApiCreditCost = apiCreditCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelResponseSdTrainingJob" /> class.
        /// </summary>
        public CreateModelResponseSdTrainingJob()
        {
        }
    }
}