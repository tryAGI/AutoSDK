//HintName: G.Models.ConvertedFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConvertedFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("export_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExportType { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// * `created` - Created<br/>
        /// * `in_progress` - In progress<br/>
        /// * `failed` - Failed<br/>
        /// * `completed` - Completed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
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
        /// Initializes a new instance of the <see cref="ConvertedFormat" /> class.
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
        /// <param name="id">
        /// Included only in responses
        /// </param>
        public ConvertedFormat(
            string exportType,
            global::G.Status7bfEnum? status,
            string? traceback,
            int id = default!)
        {
            this.ExportType = exportType ?? throw new global::System.ArgumentNullException(nameof(exportType));
            this.Id = id;
            this.Status = status;
            this.Traceback = traceback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertedFormat" /> class.
        /// </summary>
        public ConvertedFormat()
        {
        }
    }
}