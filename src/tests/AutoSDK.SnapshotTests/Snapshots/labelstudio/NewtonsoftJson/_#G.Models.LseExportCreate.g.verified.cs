//HintName: G.Models.LseExportCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LseExportCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotation_filter_options")]
        public global::G.LseAnnotationFilterOptions? AnnotationFilterOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("converted_formats")]
        public global::System.Collections.Generic.IList<global::G.ConvertedFormat>? ConvertedFormats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("counters")]
        public object? Counters { get; set; }

        /// <summary>
        /// Creation time<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// A ModelSerializer that takes additional arguments for<br/>
        /// "fields", "omit" and "expand" in order to<br/>
        /// control which fields are displayed, and whether to replace simple<br/>
        /// values with complex, nested serializations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public global::G.UserSimple? CreatedBy { get; set; }

        /// <summary>
        /// Complete or fail time
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finished_at")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("md5")]
        public string? Md5 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("serialization_options")]
        public global::G.SerializationOptions? SerializationOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.Status7bfEnumJsonConverter))]
        public global::G.Status7bfEnum? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_filter_options")]
        public global::G.LseTaskFilterOptions? TaskFilterOptions { get; set; }

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
        /// Initializes a new instance of the <see cref="LseExportCreate" /> class.
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
        /// <param name="createdAt">
        /// Creation time<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        public LseExportCreate(
            global::G.LseAnnotationFilterOptions? annotationFilterOptions,
            global::System.Collections.Generic.IList<global::G.ConvertedFormat>? convertedFormats,
            object? counters,
            global::G.UserSimple? createdBy,
            global::System.DateTime? finishedAt,
            string? md5,
            global::G.SerializationOptions? serializationOptions,
            global::G.Status7bfEnum? status,
            global::G.LseTaskFilterOptions? taskFilterOptions,
            string? title,
            global::System.DateTime createdAt = default!,
            int id = default!)
        {
            this.AnnotationFilterOptions = annotationFilterOptions;
            this.ConvertedFormats = convertedFormats;
            this.Counters = counters;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.FinishedAt = finishedAt;
            this.Id = id;
            this.Md5 = md5;
            this.SerializationOptions = serializationOptions;
            this.Status = status;
            this.TaskFilterOptions = taskFilterOptions;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseExportCreate" /> class.
        /// </summary>
        public LseExportCreate()
        {
        }
    }
}