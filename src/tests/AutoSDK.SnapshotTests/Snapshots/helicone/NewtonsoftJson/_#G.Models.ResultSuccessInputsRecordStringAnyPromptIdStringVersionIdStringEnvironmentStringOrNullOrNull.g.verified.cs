//HintName: G.Models.ResultSuccessInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNull.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNull
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::G.ResultSuccessInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNullData? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public double? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNull" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="error"></param>
        public ResultSuccessInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNull(
            global::G.ResultSuccessInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNullData? data,
            double? error)
        {
            this.Data = data;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNull" /> class.
        /// </summary>
        public ResultSuccessInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNull()
        {
        }
    }
}