//HintName: G.Models.AnnotationQueueReviewerPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public sealed partial class AnnotationQueueReviewerPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public long? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueReviewerPublic" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="status"></param>
        public AnnotationQueueReviewerPublic(
            string? username,
            long? status)
        {
            this.Username = username;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueReviewerPublic" /> class.
        /// </summary>
        public AnnotationQueueReviewerPublic()
        {
        }
    }
}