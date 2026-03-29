//HintName: G.Models.GetInternalActionExecutionLogByIdResponseStepLogResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetInternalActionExecutionLogByIdResponseStepLogResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public double Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time", Required = global::Newtonsoft.Json.Required.Always)]
        public string Time { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalActionExecutionLogByIdResponseStepLogResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="time"></param>
        public GetInternalActionExecutionLogByIdResponseStepLogResponse(
            double status,
            string time)
        {
            this.Status = status;
            this.Time = time ?? throw new global::System.ArgumentNullException(nameof(time));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalActionExecutionLogByIdResponseStepLogResponse" /> class.
        /// </summary>
        public GetInternalActionExecutionLogByIdResponseStepLogResponse()
        {
        }
    }
}