//HintName: G.Models.ApiAnnotationHistoryDestroyResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiAnnotationHistoryDestroyResponse
    {
        /// <summary>
        /// Number of removed items
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removed")]
        public int? Removed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiAnnotationHistoryDestroyResponse" /> class.
        /// </summary>
        /// <param name="removed">
        /// Number of removed items
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiAnnotationHistoryDestroyResponse(
            int? removed)
        {
            this.Removed = removed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiAnnotationHistoryDestroyResponse" /> class.
        /// </summary>
        public ApiAnnotationHistoryDestroyResponse()
        {
        }
    }
}