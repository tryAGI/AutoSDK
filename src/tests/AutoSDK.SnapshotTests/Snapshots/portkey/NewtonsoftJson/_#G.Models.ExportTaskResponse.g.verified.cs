//HintName: G.Models.ExportTaskResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExportTaskResponse
    {
        /// <summary>
        /// A message indicating the status of the export task
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// The type of the object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.ExportTaskResponseObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportTaskResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// A message indicating the status of the export task
        /// </param>
        /// <param name="object">
        /// The type of the object
        /// </param>
        public ExportTaskResponse(
            string message,
            global::G.ExportTaskResponseObject @object)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportTaskResponse" /> class.
        /// </summary>
        public ExportTaskResponse()
        {
        }
    }
}