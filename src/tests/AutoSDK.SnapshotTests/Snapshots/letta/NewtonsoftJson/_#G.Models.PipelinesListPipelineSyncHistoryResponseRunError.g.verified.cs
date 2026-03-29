//HintName: G.Models.PipelinesListPipelineSyncHistoryResponseRunError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesListPipelineSyncHistoryResponseRunError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ErrorType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message", Required = global::Newtonsoft.Json.Required.Always)]
        public string ErrorMessage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesListPipelineSyncHistoryResponseRunError" /> class.
        /// </summary>
        /// <param name="errorType"></param>
        /// <param name="errorMessage"></param>
        public PipelinesListPipelineSyncHistoryResponseRunError(
            string errorType,
            string errorMessage)
        {
            this.ErrorType = errorType ?? throw new global::System.ArgumentNullException(nameof(errorType));
            this.ErrorMessage = errorMessage ?? throw new global::System.ArgumentNullException(nameof(errorMessage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesListPipelineSyncHistoryResponseRunError" /> class.
        /// </summary>
        public PipelinesListPipelineSyncHistoryResponseRunError()
        {
        }
    }
}