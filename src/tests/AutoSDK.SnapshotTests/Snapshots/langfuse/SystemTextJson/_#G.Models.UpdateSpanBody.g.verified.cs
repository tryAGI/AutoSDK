//HintName: G.Models.UpdateSpanBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSpanBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSpanBody" /> class.
        /// </summary>
        /// <param name="endTime"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSpanBody(
            global::System.DateTime? endTime)
        {
            this.EndTime = endTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSpanBody" /> class.
        /// </summary>
        public UpdateSpanBody()
        {
        }
    }
}