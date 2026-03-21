//HintName: G.Models.GetTasksResponseVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A cancelled or deleted task
    /// </summary>
    public sealed partial class GetTasksResponseVariant3
    {
        /// <summary>
        /// The ID of the task being returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The timestamp that the task was submitted at.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"CANCELLED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "CANCELLED";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTasksResponseVariant3" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the task being returned.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp that the task was submitted at.
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTasksResponseVariant3(
            global::System.Guid id,
            global::System.DateTime createdAt,
            string status = "CANCELLED")
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTasksResponseVariant3" /> class.
        /// </summary>
        public GetTasksResponseVariant3()
        {
        }
    }
}