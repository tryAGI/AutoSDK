//HintName: G.Models.CreateAnnotationQueueRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAnnotationQueueRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scoreConfigIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> ScoreConfigIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnnotationQueueRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="scoreConfigIds"></param>
        /// <param name="description"></param>
        public CreateAnnotationQueueRequest(
            string name,
            global::System.Collections.Generic.IList<string> scoreConfigIds,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.ScoreConfigIds = scoreConfigIds ?? throw new global::System.ArgumentNullException(nameof(scoreConfigIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnnotationQueueRequest" /> class.
        /// </summary>
        public CreateAnnotationQueueRequest()
        {
        }
    }
}