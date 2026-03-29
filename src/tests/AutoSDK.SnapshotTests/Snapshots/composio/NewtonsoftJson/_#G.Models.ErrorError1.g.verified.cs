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
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public double Code { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public double Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suggested_fix")]
        public string? SuggestedFix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors")]
        public global::System.Collections.Generic.IList<string>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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