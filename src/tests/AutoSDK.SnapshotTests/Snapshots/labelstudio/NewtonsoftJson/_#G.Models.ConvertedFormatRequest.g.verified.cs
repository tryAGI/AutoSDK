//HintName: G.Models.ConvertedFormatRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConvertedFormatRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("export_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExportType { get; set; } = default!;

        /// <summary>
        /// * `created` - Created<br/>
        /// * `in_progress` - In progress<br/>
        /// * `failed` - Failed<br/>
        /// * `completed` - Completed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.Status7bfEnumJsonConverter))]
        public global::G.Status7bfEnum? Status { get; set; }

        /// <summary>
        /// Traceback report in case of errors
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("traceback")]
        public string? Traceback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertedFormatRequest" /> class.
        /// </summary>
        /// <param name="exportType"></param>
        /// <param name="status">
        /// * `created` - Created<br/>
        /// * `in_progress` - In progress<br/>
        /// * `failed` - Failed<br/>
        /// * `completed` - Completed
        /// </param>
        /// <param name="traceback">
        /// Traceback report in case of errors
        /// </param>
        public ConvertedFormatRequest(
            string exportType,
            global::G.Status7bfEnum? status,
            string? traceback)
        {
            this.ExportType = exportType ?? throw new global::System.ArgumentNullException(nameof(exportType));
            this.Status = status;
            this.Traceback = traceback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertedFormatRequest" /> class.
        /// </summary>
        public ConvertedFormatRequest()
        {
        }
    }
}