//HintName: G.Models.SurveyImportStatusVO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SurveyImportStatusVO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isComplete")]
        public bool? IsComplete { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors")]
        public global::System.Collections.Generic.IList<string>? Errors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exceptionCount")]
        public int? ExceptionCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyImportStatusVO" /> class.
        /// </summary>
        /// <param name="isComplete"></param>
        /// <param name="errors"></param>
        /// <param name="exceptionCount"></param>
        public SurveyImportStatusVO(
            bool? isComplete,
            global::System.Collections.Generic.IList<string>? errors,
            int? exceptionCount)
        {
            this.IsComplete = isComplete;
            this.Errors = errors;
            this.ExceptionCount = exceptionCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyImportStatusVO" /> class.
        /// </summary>
        public SurveyImportStatusVO()
        {
        }
    }
}