//HintName: G.Models.UpdateExcerptTextRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateExcerptTextRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectIDL", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectIDL { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excerptId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ExcerptId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExcerptTextRequest" /> class.
        /// </summary>
        /// <param name="projectIDL"></param>
        /// <param name="excerptId"></param>
        /// <param name="text"></param>
        public UpdateExcerptTextRequest(
            global::System.Guid projectIDL,
            global::System.Guid excerptId,
            string text)
        {
            this.ProjectIDL = projectIDL;
            this.ExcerptId = excerptId;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExcerptTextRequest" /> class.
        /// </summary>
        public UpdateExcerptTextRequest()
        {
        }
    }
}