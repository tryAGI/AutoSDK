//HintName: G.Models.ErrorError1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorError1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggested_fix")]
        public string? SuggestedFix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<string>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorError1" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="code"></param>
        /// <param name="slug"></param>
        /// <param name="status"></param>
        /// <param name="requestId"></param>
        /// <param name="suggestedFix"></param>
        /// <param name="errors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorError1(
            string message,
            double code,
            string slug,
            double status,
            string? requestId,
            string? suggestedFix,
            global::System.Collections.Generic.IList<string>? errors)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Code = code;
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Status = status;
            this.RequestId = requestId;
            this.SuggestedFix = suggestedFix;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorError1" /> class.
        /// </summary>
        public ErrorError1()
        {
        }
    }
}