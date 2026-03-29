//HintName: G.Models.KPIProjectMatrixSegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for 2D matrix segmentation (time × project) in compact format.<br/>
    /// Returns a 2D array where values[project_index][time_index] corresponds to<br/>
    /// projects[project_index] at interval_start[time_index].
    /// </summary>
    public sealed partial class KPIProjectMatrixSegment
    {
        /// <summary>
        /// Array of time period start timestamps
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.DateTime> IntervalStart { get; set; }

        /// <summary>
        /// Array of project information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.KPIProjectInfo> Projects { get; set; }

        /// <summary>
        /// 2D array of values: values[project_index][time_index]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>> Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIProjectMatrixSegment" /> class.
        /// </summary>
        /// <param name="intervalStart">
        /// Array of time period start timestamps
        /// </param>
        /// <param name="projects">
        /// Array of project information
        /// </param>
        /// <param name="values">
        /// 2D array of values: values[project_index][time_index]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KPIProjectMatrixSegment(
            global::System.Collections.Generic.IList<global::System.DateTime> intervalStart,
            global::System.Collections.Generic.IList<global::G.KPIProjectInfo> projects,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>> values)
        {
            this.IntervalStart = intervalStart ?? throw new global::System.ArgumentNullException(nameof(intervalStart));
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIProjectMatrixSegment" /> class.
        /// </summary>
        public KPIProjectMatrixSegment()
        {
        }
    }
}