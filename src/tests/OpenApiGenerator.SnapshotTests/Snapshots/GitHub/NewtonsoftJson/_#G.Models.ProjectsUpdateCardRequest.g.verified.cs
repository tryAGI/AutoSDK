//HintName: G.Models.ProjectsUpdateCardRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsUpdateCardRequest
    {
        /// <summary>
        /// The project card's note
        /// <br/>Example: Update all gems
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("note")]
        public string? Note { get; set; }

        /// <summary>
        /// Whether or not the card is archived
        /// <br/>Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("archived")]
        public bool Archived { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}