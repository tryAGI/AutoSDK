//HintName: G.Models.WorkspaceConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceConfiguration
    {
        /// <summary>
        /// Duration in ISO-8601 format (e.g., PT30M for 30 minutes, PT2H for 2 hours, P1D for 1 day). Minimum precision supported is seconds, please use a duration with seconds precision or higher. Also, the max duration allowed is 7 days.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_to_mark_thread_as_inactive")]
        public string? TimeoutToMarkThreadAsInactive { get; set; }

        /// <summary>
        /// Enable or disable data truncation in table views. When disabled, the frontend will limit pagination to prevent performance issues. Default: true (truncation enabled).<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation_on_tables")]
        public bool? TruncationOnTables { get; set; }

        /// <summary>
        /// Workspace-level color map. Maps label names to hex color values (e.g. #FF0000). Max 10000 entries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color_map")]
        public global::System.Collections.Generic.Dictionary<string, string>? ColorMap { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceConfiguration" /> class.
        /// </summary>
        /// <param name="timeoutToMarkThreadAsInactive">
        /// Duration in ISO-8601 format (e.g., PT30M for 30 minutes, PT2H for 2 hours, P1D for 1 day). Minimum precision supported is seconds, please use a duration with seconds precision or higher. Also, the max duration allowed is 7 days.
        /// </param>
        /// <param name="truncationOnTables">
        /// Enable or disable data truncation in table views. When disabled, the frontend will limit pagination to prevent performance issues. Default: true (truncation enabled).<br/>
        /// Example: true
        /// </param>
        /// <param name="colorMap">
        /// Workspace-level color map. Maps label names to hex color values (e.g. #FF0000). Max 10000 entries.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceConfiguration(
            string? timeoutToMarkThreadAsInactive,
            bool? truncationOnTables,
            global::System.Collections.Generic.Dictionary<string, string>? colorMap)
        {
            this.TimeoutToMarkThreadAsInactive = timeoutToMarkThreadAsInactive;
            this.TruncationOnTables = truncationOnTables;
            this.ColorMap = colorMap;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceConfiguration" /> class.
        /// </summary>
        public WorkspaceConfiguration()
        {
        }
    }
}