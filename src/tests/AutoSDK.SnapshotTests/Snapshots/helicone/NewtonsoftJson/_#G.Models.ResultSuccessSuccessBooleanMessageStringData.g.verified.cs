//HintName: G.Models.ResultSuccessSuccessBooleanMessageStringData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessSuccessBooleanMessageStringData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessSuccessBooleanMessageStringData" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="success"></param>
        public ResultSuccessSuccessBooleanMessageStringData(
            string message,
            bool success)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessSuccessBooleanMessageStringData" /> class.
        /// </summary>
        public ResultSuccessSuccessBooleanMessageStringData()
        {
        }
    }
}