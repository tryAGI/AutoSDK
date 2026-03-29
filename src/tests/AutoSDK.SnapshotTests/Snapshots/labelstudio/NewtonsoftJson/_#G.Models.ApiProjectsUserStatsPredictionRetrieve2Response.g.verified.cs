//HintName: G.Models.ApiProjectsUserStatsPredictionRetrieve2Response.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsUserStatsPredictionRetrieve2Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("average_prediction_agreement_per_user")]
        public global::G.OneOf<double?, global::System.Collections.Generic.Dictionary<string, double>>? AveragePredictionAgreementPerUser { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsUserStatsPredictionRetrieve2Response" /> class.
        /// </summary>
        /// <param name="averagePredictionAgreementPerUser"></param>
        public ApiProjectsUserStatsPredictionRetrieve2Response(
            global::G.OneOf<double?, global::System.Collections.Generic.Dictionary<string, double>>? averagePredictionAgreementPerUser)
        {
            this.AveragePredictionAgreementPerUser = averagePredictionAgreementPerUser;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsUserStatsPredictionRetrieve2Response" /> class.
        /// </summary>
        public ApiProjectsUserStatsPredictionRetrieve2Response()
        {
        }
    }
}