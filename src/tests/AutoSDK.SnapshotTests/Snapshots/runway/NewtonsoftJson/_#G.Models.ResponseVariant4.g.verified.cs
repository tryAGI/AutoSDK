//HintName: G.Models.ResponseVariant4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A running task
    /// </summary>
    public sealed partial class ResponseVariant4
    {
        /// <summary>
        /// The ID of the task being returned.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The timestamp that the task was submitted at.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <default>"RUNNING"</default>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; } = "RUNNING";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("progress", Required = global::Newtonsoft.Json.Required.Always)]
        public double Progress { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseVariant4" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the task being returned.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp that the task was submitted at.
        /// </param>
        /// <param name="status"></param>
        /// <param name="progress"></param>
        public ResponseVariant4(
            global::System.Guid id,
            global::System.DateTime createdAt,
            double progress,
            string status = "RUNNING")
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Progress = progress;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseVariant4" /> class.
        /// </summary>
        public ResponseVariant4()
        {
        }
    }
}