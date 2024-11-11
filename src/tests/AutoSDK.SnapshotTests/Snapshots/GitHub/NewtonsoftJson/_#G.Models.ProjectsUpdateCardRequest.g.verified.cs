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
        /// The project card's note<br/>
        /// Example: Update all gems
        /// </summary>
        /// <example>Update all gems</example>
        [global::Newtonsoft.Json.JsonProperty("note")]
        public string? Note { get; set; }

        /// <summary>
        /// Whether or not the card is archived<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsUpdateCardRequest" /> class.
        /// </summary>
        /// <param name="note">
        /// The project card's note<br/>
        /// Example: Update all gems
        /// </param>
        /// <param name="archived">
        /// Whether or not the card is archived<br/>
        /// Example: false
        /// </param>
        public ProjectsUpdateCardRequest(
            string? note,
            bool? archived)
        {
            this.Note = note;
            this.Archived = archived;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsUpdateCardRequest" /> class.
        /// </summary>
        public ProjectsUpdateCardRequest()
        {
        }
    }
}