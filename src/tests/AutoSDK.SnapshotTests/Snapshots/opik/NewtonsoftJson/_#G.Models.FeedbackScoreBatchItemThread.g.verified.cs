//HintName: G.Models.FeedbackScoreBatchItemThread.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackScoreBatchItemThread
    {
        /// <summary>
        /// If null, the default project is used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("category_name")]
        public string? CategoryName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FeedbackScoreBatchItemThreadSourceJsonConverter))]
        public global::G.FeedbackScoreBatchItemThreadSource Source { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author")]
        public string? Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thread_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ThreadId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackScoreBatchItemThread" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="source"></param>
        /// <param name="threadId"></param>
        /// <param name="projectName">
        /// If null, the default project is used
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="categoryName"></param>
        /// <param name="reason"></param>
        /// <param name="author"></param>
        public FeedbackScoreBatchItemThread(
            string name,
            double value,
            global::G.FeedbackScoreBatchItemThreadSource source,
            string threadId,
            string? projectName,
            global::System.Guid? projectId,
            string? categoryName,
            string? reason,
            string? author)
        {
            this.ProjectName = projectName;
            this.ProjectId = projectId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CategoryName = categoryName;
            this.Value = value;
            this.Reason = reason;
            this.Source = source;
            this.Author = author;
            this.ThreadId = threadId ?? throw new global::System.ArgumentNullException(nameof(threadId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackScoreBatchItemThread" /> class.
        /// </summary>
        public FeedbackScoreBatchItemThread()
        {
        }
    }
}