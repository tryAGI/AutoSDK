//HintName: G.Models.SafetyResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SafetyResponseModel
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_blocked_ivc")]
        public bool? IsBlockedIvc { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_blocked_non_ivc")]
        public bool? IsBlockedNonIvc { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ignore_safety_evaluation")]
        public bool? IgnoreSafetyEvaluation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SafetyResponseModel" /> class.
        /// </summary>
        /// <param name="isBlockedIvc">
        /// Default Value: false
        /// </param>
        /// <param name="isBlockedNonIvc">
        /// Default Value: false
        /// </param>
        /// <param name="ignoreSafetyEvaluation">
        /// Default Value: false
        /// </param>
        public SafetyResponseModel(
            bool? isBlockedIvc,
            bool? isBlockedNonIvc,
            bool? ignoreSafetyEvaluation)
        {
            this.IsBlockedIvc = isBlockedIvc;
            this.IsBlockedNonIvc = isBlockedNonIvc;
            this.IgnoreSafetyEvaluation = ignoreSafetyEvaluation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SafetyResponseModel" /> class.
        /// </summary>
        public SafetyResponseModel()
        {
        }
    }
}