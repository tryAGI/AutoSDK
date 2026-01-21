//HintName: G.Models.ConvertChapterResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"status":"ok"}
    /// </summary>
    public sealed partial class ConvertChapterResponseModel
    {
        /// <summary>
        /// The status of the studio chapter conversion request. If the request was successful, the status will be 'ok'. Otherwise an error message with status 500 will be returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertChapterResponseModel" /> class.
        /// </summary>
        /// <param name="status">
        /// The status of the studio chapter conversion request. If the request was successful, the status will be 'ok'. Otherwise an error message with status 500 will be returned.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConvertChapterResponseModel(
            string status)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertChapterResponseModel" /> class.
        /// </summary>
        public ConvertChapterResponseModel()
        {
        }
    }
}