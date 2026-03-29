//HintName: G.Models.ApiProjectsModelStatsPredictionRetrieveResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsModelStatsPredictionRetrieveResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("average_prediction_agreement_per_model")]
        public double? AveragePredictionAgreementPerModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsModelStatsPredictionRetrieveResponse" /> class.
        /// </summary>
        /// <param name="averagePredictionAgreementPerModel"></param>
        public ApiProjectsModelStatsPredictionRetrieveResponse(
            double? averagePredictionAgreementPerModel)
        {
            this.AveragePredictionAgreementPerModel = averagePredictionAgreementPerModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsModelStatsPredictionRetrieveResponse" /> class.
        /// </summary>
        public ApiProjectsModelStatsPredictionRetrieveResponse()
        {
        }
    }
}