//HintName: G.Models.ProblemDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProblemDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance")]
        public string? Instance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProblemDetails" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="title"></param>
        /// <param name="status"></param>
        /// <param name="detail"></param>
        /// <param name="instance"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ProblemDetails(
            string? type,
            string? title,
            int? status,
            string? detail,
            string? instance)
        {
            this.Type = type;
            this.Title = title;
            this.Status = status;
            this.Detail = detail;
            this.Instance = instance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProblemDetails" /> class.
        /// </summary>
        public ProblemDetails()
        {
        }
    }
}