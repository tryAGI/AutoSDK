//HintName: G.Models.PatchedBlueprintUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for updating a blueprint. Only title, description, and task_ids can be changed.
    /// </summary>
    public sealed partial class PatchedBlueprintUpdateRequest
    {
        /// <summary>
        /// Project description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_ids")]
        public global::System.Collections.Generic.IList<int>? TaskIds { get; set; }

        /// <summary>
        /// Blueprint name. Must be between 3 and 50 characters long.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedBlueprintUpdateRequest" /> class.
        /// </summary>
        /// <param name="description">
        /// Project description
        /// </param>
        /// <param name="taskIds">
        /// Included only in requests
        /// </param>
        /// <param name="title">
        /// Blueprint name. Must be between 3 and 50 characters long.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedBlueprintUpdateRequest(
            string? description,
            global::System.Collections.Generic.IList<int>? taskIds,
            string? title)
        {
            this.Description = description;
            this.TaskIds = taskIds;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedBlueprintUpdateRequest" /> class.
        /// </summary>
        public PatchedBlueprintUpdateRequest()
        {
        }
    }
}