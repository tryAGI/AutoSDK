//HintName: G.Models.ResultSuccessSuccessBooleanNewPosition63NumberMessageStringData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessSuccessBooleanNewPosition63NumberMessageStringData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("newPosition")]
        public double? NewPosition { get; set; }

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
        /// Initializes a new instance of the <see cref="ResultSuccessSuccessBooleanNewPosition63NumberMessageStringData" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="success"></param>
        /// <param name="newPosition"></param>
        public ResultSuccessSuccessBooleanNewPosition63NumberMessageStringData(
            string message,
            bool success,
            double? newPosition)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.NewPosition = newPosition;
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessSuccessBooleanNewPosition63NumberMessageStringData" /> class.
        /// </summary>
        public ResultSuccessSuccessBooleanNewPosition63NumberMessageStringData()
        {
        }
    }
}