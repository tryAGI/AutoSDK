//HintName: G.Models.LseTaskSerializerForAnnotatorsDraft.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LseTaskSerializerForAnnotatorsDraft
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::System.Collections.Generic.IList<object>? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseTaskSerializerForAnnotatorsDraft" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="result"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LseTaskSerializerForAnnotatorsDraft(
            global::System.DateTime? createdAt,
            global::System.Collections.Generic.IList<object>? result,
            global::System.DateTime? updatedAt)
        {
            this.CreatedAt = createdAt;
            this.Result = result;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseTaskSerializerForAnnotatorsDraft" /> class.
        /// </summary>
        public LseTaskSerializerForAnnotatorsDraft()
        {
        }
    }
}