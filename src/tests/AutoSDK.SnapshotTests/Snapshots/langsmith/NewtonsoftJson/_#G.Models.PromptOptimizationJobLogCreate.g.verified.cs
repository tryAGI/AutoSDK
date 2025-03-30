//HintName: G.Models.PromptOptimizationJobLogCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptOptimizationJobLogCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("log_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EPromptOptimizationJobLogType LogType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOptimizationJobLogCreate" /> class.
        /// </summary>
        /// <param name="logType"></param>
        /// <param name="message"></param>
        /// <param name="data"></param>
        public PromptOptimizationJobLogCreate(
            global::G.EPromptOptimizationJobLogType logType,
            string message,
            object? data)
        {
            this.LogType = logType;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOptimizationJobLogCreate" /> class.
        /// </summary>
        public PromptOptimizationJobLogCreate()
        {
        }
    }
}