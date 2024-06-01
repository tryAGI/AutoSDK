//HintName: G.Models.ProjectsCreateCardRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsCreateCardRequest
    {
        /// <summary>
        /// The project card's note
        /// <br/>Example: Update all gems
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Note { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}