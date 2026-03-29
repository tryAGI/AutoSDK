//HintName: G.Models.PostInternalTriggerLogsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostInternalTriggerLogsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::G.PostInternalTriggerLogsResponseDataItem>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostInternalTriggerLogsResponse" /> class.
        /// </summary>
        /// <param name="nextCursor"></param>
        /// <param name="data">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostInternalTriggerLogsResponse(
            string? nextCursor,
            global::System.Collections.Generic.IList<global::G.PostInternalTriggerLogsResponseDataItem>? data)
        {
            this.NextCursor = nextCursor;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostInternalTriggerLogsResponse" /> class.
        /// </summary>
        public PostInternalTriggerLogsResponse()
        {
        }
    }
}