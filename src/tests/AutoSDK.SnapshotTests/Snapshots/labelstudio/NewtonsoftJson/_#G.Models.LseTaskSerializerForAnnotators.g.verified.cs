//HintName: G.Models.LseTaskSerializerForAnnotators.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Data Manager Task Serializer with FSM state support.
    /// </summary>
    public sealed partial class LseTaskSerializerForAnnotators
    {
        /// <summary>
        /// Default Value: []<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("annotations")]
        public string Annotations { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("annotations_results")]
        public string AnnotationsResults { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cancelled_annotations")]
        public int? CancelledAnnotations { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("comment_count")]
        public string CommentCount { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("comments")]
        public string Comments { get; set; } = default!;

        /// <summary>
        /// Time a task was created<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// User imported or uploaded data for a task. Data is formatted according to the project label config. You can find examples of data for your project on the Import page in the Label Studio Data Manager UI.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public object Data { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("draft_exists")]
        public bool? DraftExists { get; set; }

        /// <summary>
        /// Drafts for this task<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("drafts")]
        public global::System.Collections.Generic.IList<global::G.LseTaskSerializerForAnnotatorsDraft> Drafts { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Predictions for this task<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("predictions")]
        public global::System.Collections.Generic.IList<global::G.LseTaskSerializerForAnnotatorsPrediction> Predictions { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("predictions_results")]
        public string PredictionsResults { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("predictions_score")]
        public double? PredictionsScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reviews_rejected")]
        public int? ReviewsRejected { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public string State { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_annotations")]
        public int? TotalAnnotations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_predictions")]
        public int? TotalPredictions { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("unresolved_comment_count")]
        public string UnresolvedCommentCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseTaskSerializerForAnnotators" /> class.
        /// </summary>
        /// <param name="data">
        /// User imported or uploaded data for a task. Data is formatted according to the project label config. You can find examples of data for your project on the Import page in the Label Studio Data Manager UI.
        /// </param>
        /// <param name="cancelledAnnotations"></param>
        /// <param name="draftExists"></param>
        /// <param name="predictionsScore"></param>
        /// <param name="reviewsRejected"></param>
        /// <param name="totalAnnotations"></param>
        /// <param name="totalPredictions"></param>
        /// <param name="annotations">
        /// Default Value: []<br/>
        /// Included only in responses
        /// </param>
        /// <param name="annotationsResults">
        /// Included only in responses
        /// </param>
        /// <param name="commentCount">
        /// Included only in responses
        /// </param>
        /// <param name="comments">
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Time a task was created<br/>
        /// Included only in responses
        /// </param>
        /// <param name="drafts">
        /// Drafts for this task<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="predictions">
        /// Predictions for this task<br/>
        /// Included only in responses
        /// </param>
        /// <param name="predictionsResults">
        /// Included only in responses
        /// </param>
        /// <param name="state">
        /// Included only in responses
        /// </param>
        /// <param name="unresolvedCommentCount">
        /// Included only in responses
        /// </param>
        public LseTaskSerializerForAnnotators(
            object data,
            int? cancelledAnnotations,
            bool? draftExists,
            double? predictionsScore,
            int? reviewsRejected,
            int? totalAnnotations,
            int? totalPredictions,
            string annotations = default!,
            string annotationsResults = default!,
            string commentCount = default!,
            string comments = default!,
            global::System.DateTime createdAt = default!,
            global::System.Collections.Generic.IList<global::G.LseTaskSerializerForAnnotatorsDraft> drafts = default!,
            int id = default!,
            global::System.Collections.Generic.IList<global::G.LseTaskSerializerForAnnotatorsPrediction> predictions = default!,
            string predictionsResults = default!,
            string state = default!,
            string unresolvedCommentCount = default!)
        {
            this.Annotations = annotations;
            this.AnnotationsResults = annotationsResults;
            this.CancelledAnnotations = cancelledAnnotations;
            this.CommentCount = commentCount;
            this.Comments = comments;
            this.CreatedAt = createdAt;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.DraftExists = draftExists;
            this.Drafts = drafts;
            this.Id = id;
            this.Predictions = predictions;
            this.PredictionsResults = predictionsResults;
            this.PredictionsScore = predictionsScore;
            this.ReviewsRejected = reviewsRejected;
            this.State = state;
            this.TotalAnnotations = totalAnnotations;
            this.TotalPredictions = totalPredictions;
            this.UnresolvedCommentCount = unresolvedCommentCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseTaskSerializerForAnnotators" /> class.
        /// </summary>
        public LseTaskSerializerForAnnotators()
        {
        }
    }
}