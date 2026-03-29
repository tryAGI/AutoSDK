//HintName: G.Models.FeedbackRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackRequest
    {
        /// <summary>
        /// Unique identifier for the request trace.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TraceId { get; set; } = default!;

        /// <summary>
        /// Feedback value, an integer between -10 and 10.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public int Value { get; set; } = default!;

        /// <summary>
        /// Weight of the feedback, a float between 0 and 1. Default is 1.0.<br/>
        /// Default Value: 1.0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weight")]
        public float? Weight { get; set; }

        /// <summary>
        /// Additional metadata for the feedback.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackRequest" /> class.
        /// </summary>
        /// <param name="traceId">
        /// Unique identifier for the request trace.
        /// </param>
        /// <param name="value">
        /// Feedback value, an integer between -10 and 10.
        /// </param>
        /// <param name="weight">
        /// Weight of the feedback, a float between 0 and 1. Default is 1.0.<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="metadata">
        /// Additional metadata for the feedback.
        /// </param>
        public FeedbackRequest(
            string traceId,
            int value,
            float? weight,
            object? metadata)
        {
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
            this.Value = value;
            this.Weight = weight;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackRequest" /> class.
        /// </summary>
        public FeedbackRequest()
        {
        }
    }
}