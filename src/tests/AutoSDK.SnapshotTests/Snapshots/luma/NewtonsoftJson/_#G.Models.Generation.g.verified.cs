//HintName: G.Models.Generation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The generation response object
    /// </summary>
    public sealed partial class Generation
    {
        /// <summary>
        /// The assets of the generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assets")]
        public global::G.Assets? Assets { get; set; }

        /// <summary>
        /// The date and time when the generation was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The reason for the state of the generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failure_reason")]
        public string? FailureReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generation_type")]
        public global::G.GenerationType? GenerationType { get; set; }

        /// <summary>
        /// The ID of the generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// The model used for the generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The request of the generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request")]
        public global::G.Request? Request { get; set; }

        /// <summary>
        /// The state of the generation<br/>
        /// Example: completed
        /// </summary>
        /// <example>completed</example>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::G.State? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Generation" /> class.
        /// </summary>
        /// <param name="assets">
        /// The assets of the generation
        /// </param>
        /// <param name="createdAt">
        /// The date and time when the generation was created
        /// </param>
        /// <param name="failureReason">
        /// The reason for the state of the generation
        /// </param>
        /// <param name="generationType"></param>
        /// <param name="id">
        /// The ID of the generation
        /// </param>
        /// <param name="model">
        /// The model used for the generation
        /// </param>
        /// <param name="request">
        /// The request of the generation
        /// </param>
        /// <param name="state">
        /// The state of the generation<br/>
        /// Example: completed
        /// </param>
        public Generation(
            global::G.Assets? assets,
            global::System.DateTime? createdAt,
            string? failureReason,
            global::G.GenerationType? generationType,
            global::System.Guid? id,
            string? model,
            global::G.Request? request,
            global::G.State? state)
        {
            this.Assets = assets;
            this.CreatedAt = createdAt;
            this.FailureReason = failureReason;
            this.GenerationType = generationType;
            this.Id = id;
            this.Model = model;
            this.Request = request;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Generation" /> class.
        /// </summary>
        public Generation()
        {
        }
    }
}