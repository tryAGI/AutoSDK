//HintName: G.Models.FeedbackExperimentItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackExperimentItem
    {
        /// <summary>
        /// The id of the experiment event to log feedback for. This is the row `id` returned by `POST /v1/experiment/{experiment_id}/insert`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// A dictionary of numeric values (between 0 and 1) to log. These scores will be merged into the existing scores for the experiment event
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scores")]
        public global::System.Collections.Generic.Dictionary<string, double?>? Scores { get; set; }

        /// <summary>
        /// The ground truth value (an arbitrary, JSON serializable object) that you'd compare to `output` to determine if your `output` value is correct or not
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expected")]
        public object? Expected { get; set; }

        /// <summary>
        /// An optional comment string to log about the experiment event
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// A dictionary with additional data about the feedback. If you have a `user_id`, you can log it here and access it in the Braintrust UI. Note, this metadata does not correspond to the main event itself, but rather the audit log attached to the event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Metadata { get; set; }

        /// <summary>
        /// The source of the feedback. Must be one of "external" (default), "app", or "api"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FeedbackExperimentItemSourceJsonConverter))]
        public global::G.FeedbackExperimentItemSource? Source { get; set; }

        /// <summary>
        /// A list of tags to log
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackExperimentItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the experiment event to log feedback for. This is the row `id` returned by `POST /v1/experiment/{experiment_id}/insert`
        /// </param>
        /// <param name="scores">
        /// A dictionary of numeric values (between 0 and 1) to log. These scores will be merged into the existing scores for the experiment event
        /// </param>
        /// <param name="expected">
        /// The ground truth value (an arbitrary, JSON serializable object) that you'd compare to `output` to determine if your `output` value is correct or not
        /// </param>
        /// <param name="comment">
        /// An optional comment string to log about the experiment event
        /// </param>
        /// <param name="metadata">
        /// A dictionary with additional data about the feedback. If you have a `user_id`, you can log it here and access it in the Braintrust UI. Note, this metadata does not correspond to the main event itself, but rather the audit log attached to the event.
        /// </param>
        /// <param name="source">
        /// The source of the feedback. Must be one of "external" (default), "app", or "api"
        /// </param>
        /// <param name="tags">
        /// A list of tags to log
        /// </param>
        public FeedbackExperimentItem(
            string id,
            global::System.Collections.Generic.Dictionary<string, double?>? scores,
            object? expected,
            string? comment,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata,
            global::G.FeedbackExperimentItemSource? source,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Scores = scores;
            this.Expected = expected;
            this.Comment = comment;
            this.Metadata = metadata;
            this.Source = source;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackExperimentItem" /> class.
        /// </summary>
        public FeedbackExperimentItem()
        {
        }
    }
}