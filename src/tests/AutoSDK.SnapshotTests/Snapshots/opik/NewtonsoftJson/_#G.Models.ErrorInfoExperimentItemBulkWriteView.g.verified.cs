//HintName: G.Models.ErrorInfoExperimentItemBulkWriteView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorInfoExperimentItemBulkWriteView
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exception_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExceptionType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("traceback", Required = global::Newtonsoft.Json.Required.Always)]
        public string Traceback { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorInfoExperimentItemBulkWriteView" /> class.
        /// </summary>
        /// <param name="exceptionType"></param>
        /// <param name="traceback"></param>
        /// <param name="message"></param>
        public ErrorInfoExperimentItemBulkWriteView(
            string exceptionType,
            string traceback,
            string? message)
        {
            this.ExceptionType = exceptionType ?? throw new global::System.ArgumentNullException(nameof(exceptionType));
            this.Message = message;
            this.Traceback = traceback ?? throw new global::System.ArgumentNullException(nameof(traceback));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorInfoExperimentItemBulkWriteView" /> class.
        /// </summary>
        public ErrorInfoExperimentItemBulkWriteView()
        {
        }
    }
}