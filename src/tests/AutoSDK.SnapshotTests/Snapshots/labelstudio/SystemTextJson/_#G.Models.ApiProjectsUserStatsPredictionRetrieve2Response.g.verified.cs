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
        [global::System.Text.Json.Serialization.JsonPropertyName("average_prediction_agreement_per_user")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>))]
        public global::G.OneOf<double?, global::System.Collections.Generic.Dictionary<string, double>>? AveragePredictionAgreementPerUser { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsUserStatsPredictionRetrieve2Response" /> class.
        /// </summary>
        /// <param name="averagePredictionAgreementPerUser"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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