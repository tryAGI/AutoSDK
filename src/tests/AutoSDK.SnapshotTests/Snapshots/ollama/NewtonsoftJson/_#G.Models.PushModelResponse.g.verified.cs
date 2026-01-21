//HintName: G.Models.PushModelResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Response class for pushing a model.
    /// </summary>
    public sealed partial class PushModelResponse
    {
        /// <summary>
        /// Status pushing the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.AnyOf<string, global::G.PushModelResponseStatus?>? Status { get; set; }

        /// <summary>
        /// the model's digest<br/>
        /// Example: sha256:bc07c81de745696fdf5afca05e065818a8149fb0c77266fb584d9b2cba3711a
        /// </summary>
        /// <example>sha256:bc07c81de745696fdf5afca05e065818a8149fb0c77266fb584d9b2cba3711a</example>
        [global::Newtonsoft.Json.JsonProperty("digest")]
        public string? Digest { get; set; }

        /// <summary>
        /// total size of the model<br/>
        /// Example: 2142590208
        /// </summary>
        /// <example>2142590208</example>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public long? Total { get; set; }

        /// <summary>
        /// Total bytes transferred.<br/>
        /// Example: 2142590208
        /// </summary>
        /// <example>2142590208</example>
        [global::Newtonsoft.Json.JsonProperty("completed")]
        public long? Completed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PushModelResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Status pushing the model.
        /// </param>
        /// <param name="digest">
        /// the model's digest<br/>
        /// Example: sha256:bc07c81de745696fdf5afca05e065818a8149fb0c77266fb584d9b2cba3711a
        /// </param>
        /// <param name="total">
        /// total size of the model<br/>
        /// Example: 2142590208
        /// </param>
        /// <param name="completed">
        /// Total bytes transferred.<br/>
        /// Example: 2142590208
        /// </param>
        public PushModelResponse(
            global::G.AnyOf<string, global::G.PushModelResponseStatus?>? status,
            string? digest,
            long? total,
            long? completed)
        {
            this.Status = status;
            this.Digest = digest;
            this.Total = total;
            this.Completed = completed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PushModelResponse" /> class.
        /// </summary>
        public PushModelResponse()
        {
        }
    }
}