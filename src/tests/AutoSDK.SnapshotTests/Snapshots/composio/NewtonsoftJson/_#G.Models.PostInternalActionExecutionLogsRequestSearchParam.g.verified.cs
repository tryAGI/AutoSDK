//HintName: G.Models.PostInternalActionExecutionLogsRequestSearchParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostInternalActionExecutionLogsRequestSearchParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("field")]
        public string? Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operation")]
        public string? Operation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostInternalActionExecutionLogsRequestSearchParam" /> class.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="operation"></param>
        /// <param name="value"></param>
        public PostInternalActionExecutionLogsRequestSearchParam(
            string? field,
            string? operation,
            string? value)
        {
            this.Field = field;
            this.Operation = operation;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostInternalActionExecutionLogsRequestSearchParam" /> class.
        /// </summary>
        public PostInternalActionExecutionLogsRequestSearchParam()
        {
        }
    }
}