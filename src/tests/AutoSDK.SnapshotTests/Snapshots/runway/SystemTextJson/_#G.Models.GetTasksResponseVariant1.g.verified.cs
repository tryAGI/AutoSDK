//HintName: G.Models.GetTasksResponseVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A pending task
    /// </summary>
    public sealed partial class GetTasksResponseVariant1
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
        /// <default>"PENDING"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "PENDING";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTasksResponseVariant1" /> class.
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
        public GetTasksResponseVariant1(
            global::System.Guid id,
            global::System.DateTime createdAt,
            string status = "PENDING")
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTasksResponseVariant1" /> class.
        /// </summary>
        public GetTasksResponseVariant1()
        {
        }
    }
}