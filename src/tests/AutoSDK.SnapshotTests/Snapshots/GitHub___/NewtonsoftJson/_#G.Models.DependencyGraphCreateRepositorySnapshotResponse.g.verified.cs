//HintName: G.Models.DependencyGraphCreateRepositorySnapshotResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependencyGraphCreateRepositorySnapshotResponse
    {
        /// <summary>
        /// ID of the created snapshot.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The time at which the snapshot was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Either "SUCCESS", "ACCEPTED", or "INVALID". "SUCCESS" indicates that the snapshot was successfully created and the repository's dependencies were updated. "ACCEPTED" indicates that the snapshot was successfully created, but the repository's dependencies were not updated. "INVALID" indicates that the snapshot was malformed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result", Required = global::Newtonsoft.Json.Required.Always)]
        public string Result { get; set; } = default!;

        /// <summary>
        /// A message providing further details about the result, such as why the dependencies were not updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphCreateRepositorySnapshotResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the created snapshot.
        /// </param>
        /// <param name="createdAt">
        /// The time at which the snapshot was created.
        /// </param>
        /// <param name="result">
        /// Either "SUCCESS", "ACCEPTED", or "INVALID". "SUCCESS" indicates that the snapshot was successfully created and the repository's dependencies were updated. "ACCEPTED" indicates that the snapshot was successfully created, but the repository's dependencies were not updated. "INVALID" indicates that the snapshot was malformed.
        /// </param>
        /// <param name="message">
        /// A message providing further details about the result, such as why the dependencies were not updated.
        /// </param>
        public DependencyGraphCreateRepositorySnapshotResponse(
            int id,
            string createdAt,
            string result,
            string message)
        {
            this.Id = id;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphCreateRepositorySnapshotResponse" /> class.
        /// </summary>
        public DependencyGraphCreateRepositorySnapshotResponse()
        {
        }
    }
}