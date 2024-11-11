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
        [global::System.Text.Json.Serialization.JsonPropertyName("isComplete")]
        public bool? IsComplete { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<string>? Errors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exceptionCount")]
        public int? ExceptionCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyImportStatusVO" /> class.
        /// </summary>
        /// <param name="isComplete"></param>
        /// <param name="errors"></param>
        /// <param name="exceptionCount"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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