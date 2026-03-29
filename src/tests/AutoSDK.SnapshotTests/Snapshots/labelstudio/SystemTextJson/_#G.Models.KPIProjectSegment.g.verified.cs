//HintName: G.Models.KPIProjectSegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for project-segmented KPI data (compact format).<br/>
    /// Returns parallel arrays: projects and values.<br/>
    /// Note: Values can be numbers (for count/time/ratio KPIs) or strings<br/>
    /// (for category KPIs like project_state).
    /// </summary>
    public sealed partial class KPIProjectSegment
    {
        /// <summary>
        /// Array of project information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.KPIProjectInfo> Projects { get; set; }

        /// <summary>
        /// Array of KPI values, one per project (parallel to projects array). Can be numbers or strings depending on KPI type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIProjectSegment" /> class.
        /// </summary>
        /// <param name="projects">
        /// Array of project information
        /// </param>
        /// <param name="values">
        /// Array of KPI values, one per project (parallel to projects array). Can be numbers or strings depending on KPI type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KPIProjectSegment(
            global::System.Collections.Generic.IList<global::G.KPIProjectInfo> projects,
            global::System.Collections.Generic.IList<string> values)
        {
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIProjectSegment" /> class.
        /// </summary>
        public KPIProjectSegment()
        {
        }
    }
}