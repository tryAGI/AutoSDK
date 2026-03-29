//HintName: G.Models.PromptVersionSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptVersionSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_id")]
        public global::System.Guid? PromptId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_template")]
        public object? PromptTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_version")]
        public double? PromptVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_description")]
        public string? PromptDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label_id")]
        public global::System.Guid? LabelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.PromptVersionSummaryStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.PromptVersionSummaryObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionSummary" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="promptId"></param>
        /// <param name="promptTemplate"></param>
        /// <param name="promptVersion"></param>
        /// <param name="promptDescription"></param>
        /// <param name="labelId"></param>
        /// <param name="createdAt"></param>
        /// <param name="status"></param>
        /// <param name="object"></param>
        public PromptVersionSummary(
            global::System.Guid? id,
            global::System.Guid? promptId,
            object? promptTemplate,
            double? promptVersion,
            string? promptDescription,
            global::System.Guid? labelId,
            global::System.DateTime? createdAt,
            global::G.PromptVersionSummaryStatus? status,
            global::G.PromptVersionSummaryObject? @object)
        {
            this.Id = id;
            this.PromptId = promptId;
            this.PromptTemplate = promptTemplate;
            this.PromptVersion = promptVersion;
            this.PromptDescription = promptDescription;
            this.LabelId = labelId;
            this.CreatedAt = createdAt;
            this.Status = status;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionSummary" /> class.
        /// </summary>
        public PromptVersionSummary()
        {
        }
    }
}