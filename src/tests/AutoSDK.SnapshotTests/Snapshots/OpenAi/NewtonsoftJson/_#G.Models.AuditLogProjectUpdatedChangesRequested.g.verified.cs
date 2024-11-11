//HintName: G.Models.AuditLogProjectUpdatedChangesRequested.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The payload used to update the project.
    /// </summary>
    public sealed partial class AuditLogProjectUpdatedChangesRequested
    {
        /// <summary>
        /// The title of the project as seen on the dashboard.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogProjectUpdatedChangesRequested" /> class.
        /// </summary>
        /// <param name="title">
        /// The title of the project as seen on the dashboard.
        /// </param>
        public AuditLogProjectUpdatedChangesRequested(
            string? title)
        {
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogProjectUpdatedChangesRequested" /> class.
        /// </summary>
        public AuditLogProjectUpdatedChangesRequested()
        {
        }
    }
}