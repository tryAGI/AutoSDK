//HintName: G.Models.GetTasksResponseVariant6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A succeeded task
    /// </summary>
    public sealed partial class GetTasksResponseVariant6
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
        /// <default>"SUCCEEDED"</default>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; } = "SUCCEEDED";

        /// <summary>
        /// An array of URLs that return the output of the task. These URLs will expire within 24-48 hours; fetch the task again to get fresh URLs. It is expected that you download the assets at these URLs and store them in your own storage system.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Output { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTasksResponseVariant6" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the task being returned.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp that the task was submitted at.
        /// </param>
        /// <param name="output">
        /// An array of URLs that return the output of the task. These URLs will expire within 24-48 hours; fetch the task again to get fresh URLs. It is expected that you download the assets at these URLs and store them in your own storage system.
        /// </param>
        /// <param name="status"></param>
        public GetTasksResponseVariant6(
            global::System.Guid id,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.IList<string> output,
            string status = "SUCCEEDED")
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Status = status;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTasksResponseVariant6" /> class.
        /// </summary>
        public GetTasksResponseVariant6()
        {
        }
    }
}