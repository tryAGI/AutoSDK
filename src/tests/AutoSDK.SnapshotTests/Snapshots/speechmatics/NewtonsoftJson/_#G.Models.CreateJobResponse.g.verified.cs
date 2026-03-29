//HintName: G.Models.CreateJobResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"id":"a1b2c3d4e5"}
    /// </summary>
    public sealed partial class CreateJobResponse
    {
        /// <summary>
        /// The unique ID assigned to the job. Keep a record of this for later retrieval of your completed job.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateJobResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID assigned to the job. Keep a record of this for later retrieval of your completed job.
        /// </param>
        public CreateJobResponse(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateJobResponse" /> class.
        /// </summary>
        public CreateJobResponse()
        {
        }
    }
}