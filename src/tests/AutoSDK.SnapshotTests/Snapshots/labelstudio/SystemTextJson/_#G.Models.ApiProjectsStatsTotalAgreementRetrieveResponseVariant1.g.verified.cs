//HintName: G.Models.ApiProjectsStatsTotalAgreementRetrieveResponseVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsStatsTotalAgreementRetrieveResponseVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_agreement")]
        public double? TotalAgreement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsTotalAgreementRetrieveResponseVariant1" /> class.
        /// </summary>
        /// <param name="totalAgreement"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiProjectsStatsTotalAgreementRetrieveResponseVariant1(
            double? totalAgreement)
        {
            this.TotalAgreement = totalAgreement;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsTotalAgreementRetrieveResponseVariant1" /> class.
        /// </summary>
        public ApiProjectsStatsTotalAgreementRetrieveResponseVariant1()
        {
        }
    }
}