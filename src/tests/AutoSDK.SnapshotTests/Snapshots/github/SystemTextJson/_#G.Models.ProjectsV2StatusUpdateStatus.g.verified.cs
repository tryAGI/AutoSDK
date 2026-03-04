//HintName: G.Models.ProjectsV2StatusUpdateStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectsV2StatusUpdateStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Inactive,
        /// <summary>
        /// 
        /// </summary>
        OnTrack,
        /// <summary>
        /// 
        /// </summary>
        AtRisk,
        /// <summary>
        /// 
        /// </summary>
        OffTrack,
        /// <summary>
        /// 
        /// </summary>
        Complete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectsV2StatusUpdateStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsV2StatusUpdateStatus value)
        {
            return value switch
            {
                ProjectsV2StatusUpdateStatus.Inactive => "INACTIVE",
                ProjectsV2StatusUpdateStatus.OnTrack => "ON_TRACK",
                ProjectsV2StatusUpdateStatus.AtRisk => "AT_RISK",
                ProjectsV2StatusUpdateStatus.OffTrack => "OFF_TRACK",
                ProjectsV2StatusUpdateStatus.Complete => "COMPLETE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsV2StatusUpdateStatus? ToEnum(string value)
        {
            return value switch
            {
                "INACTIVE" => ProjectsV2StatusUpdateStatus.Inactive,
                "ON_TRACK" => ProjectsV2StatusUpdateStatus.OnTrack,
                "AT_RISK" => ProjectsV2StatusUpdateStatus.AtRisk,
                "OFF_TRACK" => ProjectsV2StatusUpdateStatus.OffTrack,
                "COMPLETE" => ProjectsV2StatusUpdateStatus.Complete,
                _ => null,
            };
        }
    }
}