//HintName: G.Models.LseExportCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LseExportCreateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotation_filter_options")]
        public global::G.LseAnnotationFilterOptionsRequest? AnnotationFilterOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("converted_formats")]
        public global::System.Collections.Generic.IList<global::G.ConvertedFormatRequest>? ConvertedFormats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("counters")]
        public object? Counters { get; set; }

        /// <summary>
        /// A ModelSerializer that takes additional arguments for<br/>
        /// "fields", "omit" and "expand" in order to<br/>
        /// control which fields are displayed, and whether to replace simple<br/>
        /// values with complex, nested serializations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public global::G.UserSimpleRequest? CreatedBy { get; set; }

        /// <summary>
        /// Complete or fail time
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finished_at")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("md5")]
        public string? Md5 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("serialization_options")]
        public global::G.SerializationOptionsRequest? SerializationOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.Status7bfEnum? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_filter_options")]
        public global::G.LseTaskFilterOptionsRequest? TaskFilterOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseExportCreateRequest" /> class.
        /// </summary>
        /// <param name="annotationFilterOptions"></param>
        /// <param name="convertedFormats"></param>
        /// <param name="counters"></param>
        /// <param name="createdBy">
        /// A ModelSerializer that takes additional arguments for<br/>
        /// "fields", "omit" and "expand" in order to<br/>
        /// control which fields are displayed, and whether to replace simple<br/>
        /// values with complex, nested serializations
        /// </param>
        /// <param name="finishedAt">
        /// Complete or fail time
        /// </param>
        /// <param name="md5"></param>
        /// <param name="serializationOptions"></param>
        /// <param name="status"></param>
        /// <param name="taskFilterOptions"></param>
        /// <param name="title"></param>
        public LseExportCreateRequest(
            global::G.LseAnnotationFilterOptionsRequest? annotationFilterOptions,
            global::System.Collections.Generic.IList<global::G.ConvertedFormatRequest>? convertedFormats,
            object? counters,
            global::G.UserSimpleRequest? createdBy,
            global::System.DateTime? finishedAt,
            string? md5,
            global::G.SerializationOptionsRequest? serializationOptions,
            global::G.Status7bfEnum? status,
            global::G.LseTaskFilterOptionsRequest? taskFilterOptions,
            string? title)
        {
            this.AnnotationFilterOptions = annotationFilterOptions;
            this.ConvertedFormats = convertedFormats;
            this.Counters = counters;
            this.CreatedBy = createdBy;
            this.FinishedAt = finishedAt;
            this.Md5 = md5;
            this.SerializationOptions = serializationOptions;
            this.Status = status;
            this.TaskFilterOptions = taskFilterOptions;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseExportCreateRequest" /> class.
        /// </summary>
        public LseExportCreateRequest()
        {
        }
    }
}