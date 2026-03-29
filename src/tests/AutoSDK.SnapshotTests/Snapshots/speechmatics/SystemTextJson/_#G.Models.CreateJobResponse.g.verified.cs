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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateJobResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID assigned to the job. Keep a record of this for later retrieval of your completed job.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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