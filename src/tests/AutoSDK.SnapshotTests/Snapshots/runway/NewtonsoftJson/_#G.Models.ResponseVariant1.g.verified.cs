//HintName: G.Models.ResponseVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A pending task
    /// </summary>
    public sealed partial class ResponseVariant1
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
        /// <default>"PENDING"</default>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; } = "PENDING";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseVariant1" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the task being returned.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp that the task was submitted at.
        /// </param>
        /// <param name="status"></param>
        public ResponseVariant1(
            global::System.Guid id,
            global::System.DateTime createdAt,
            string status = "PENDING")
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseVariant1" /> class.
        /// </summary>
        public ResponseVariant1()
        {
        }
    }
}