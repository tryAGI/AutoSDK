//HintName: G.Models.LseTaskSerializerForReviewersDraft.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LseTaskSerializerForReviewersDraft
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public global::System.Collections.Generic.IList<object>? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseTaskSerializerForReviewersDraft" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="result"></param>
        /// <param name="updatedAt"></param>
        public LseTaskSerializerForReviewersDraft(
            global::System.DateTime? createdAt,
            global::System.Collections.Generic.IList<object>? result,
            global::System.DateTime? updatedAt)
        {
            this.CreatedAt = createdAt;
            this.Result = result;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseTaskSerializerForReviewersDraft" /> class.
        /// </summary>
        public LseTaskSerializerForReviewersDraft()
        {
        }
    }
}