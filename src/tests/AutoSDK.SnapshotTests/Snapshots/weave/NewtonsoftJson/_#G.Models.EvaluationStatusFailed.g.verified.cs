//HintName: G.Models.EvaluationStatusFailed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationStatusFailed
    {
        /// <summary>
        /// Default Value: failed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationStatusFailed" /> class.
        /// </summary>
        /// <param name="code">
        /// Default Value: failed
        /// </param>
        /// <param name="error"></param>
        public EvaluationStatusFailed(
            string? code,
            string? error)
        {
            this.Code = code;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationStatusFailed" /> class.
        /// </summary>
        public EvaluationStatusFailed()
        {
        }
    }
}