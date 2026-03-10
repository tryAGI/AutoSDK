//HintName: G.Models.LanguageDetectionToolResultModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LanguageDetectionToolResultModel
    {
        /// <summary>
        /// Default Value: language_detection_success
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_type")]
        public string? ResultType { get; set; }

        /// <summary>
        /// Default Value: success
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageDetectionToolResultModel" /> class.
        /// </summary>
        /// <param name="resultType">
        /// Default Value: language_detection_success
        /// </param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
        /// <param name="reason"></param>
        /// <param name="language"></param>
        public LanguageDetectionToolResultModel(
            string? resultType,
            string? status,
            string? reason,
            string? language)
        {
            this.ResultType = resultType;
            this.Status = status;
            this.Reason = reason;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageDetectionToolResultModel" /> class.
        /// </summary>
        public LanguageDetectionToolResultModel()
        {
        }
    }
}