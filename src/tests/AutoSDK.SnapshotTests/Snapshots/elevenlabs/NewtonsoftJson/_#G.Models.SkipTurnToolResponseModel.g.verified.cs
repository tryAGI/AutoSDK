//HintName: G.Models.SkipTurnToolResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SkipTurnToolResponseModel
    {
        /// <summary>
        /// Default Value: skip_turn_success
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkipTurnToolResponseModel" /> class.
        /// </summary>
        /// <param name="resultType">
        /// Default Value: skip_turn_success
        /// </param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
        /// <param name="reason"></param>
        public SkipTurnToolResponseModel(
            string? resultType,
            string? status,
            string? reason)
        {
            this.ResultType = resultType;
            this.Status = status;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkipTurnToolResponseModel" /> class.
        /// </summary>
        public SkipTurnToolResponseModel()
        {
        }
    }
}