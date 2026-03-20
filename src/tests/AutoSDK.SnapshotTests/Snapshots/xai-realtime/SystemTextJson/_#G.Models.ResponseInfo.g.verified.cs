//HintName: G.Models.ResponseInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response information from the server.
    /// </summary>
    public sealed partial class ResponseInfo
    {
        /// <summary>
        /// Response ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Object type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Response status (in_progress, completed).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseInfo" /> class.
        /// </summary>
        /// <param name="id">
        /// Response ID.
        /// </param>
        /// <param name="object">
        /// Object type.
        /// </param>
        /// <param name="status">
        /// Response status (in_progress, completed).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseInfo(
            string? id,
            string? @object,
            string? status)
        {
            this.Id = id;
            this.Object = @object;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseInfo" /> class.
        /// </summary>
        public ResponseInfo()
        {
        }
    }
}