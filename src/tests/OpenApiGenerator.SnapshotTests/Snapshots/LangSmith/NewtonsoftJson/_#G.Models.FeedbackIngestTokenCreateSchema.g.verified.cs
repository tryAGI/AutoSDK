//HintName: G.Models.FeedbackIngestTokenCreateSchema.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Feedback ingest token create schema.
    /// </summary>
    public sealed partial class FeedbackIngestTokenCreateSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_in")]
        public global::System.AnyOf<global::G.TimedeltaInput?, object?>? ExpiresIn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public global::System.AnyOf<global::System.DateTime, object?>? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RunId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string FeedbackKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_config")]
        public global::System.AnyOf<global::G.FeedbackConfig?, object?>? FeedbackConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}