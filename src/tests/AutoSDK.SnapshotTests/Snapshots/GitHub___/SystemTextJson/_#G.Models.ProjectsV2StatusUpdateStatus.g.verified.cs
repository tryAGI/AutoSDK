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
        INACTIVE,
        /// <summary>
        /// 
        /// </summary>
        ONTRACK,
        /// <summary>
        /// 
        /// </summary>
        ATRISK,
        /// <summary>
        /// 
        /// </summary>
        OFFTRACK,
        /// <summary>
        /// 
        /// </summary>
        COMPLETE,
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
                ProjectsV2StatusUpdateStatus.INACTIVE => "INACTIVE",
                ProjectsV2StatusUpdateStatus.ONTRACK => "ON_TRACK",
                ProjectsV2StatusUpdateStatus.ATRISK => "AT_RISK",
                ProjectsV2StatusUpdateStatus.OFFTRACK => "OFF_TRACK",
                ProjectsV2StatusUpdateStatus.COMPLETE => "COMPLETE",
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
                "INACTIVE" => ProjectsV2StatusUpdateStatus.INACTIVE,
                "ON_TRACK" => ProjectsV2StatusUpdateStatus.ONTRACK,
                "AT_RISK" => ProjectsV2StatusUpdateStatus.ATRISK,
                "OFF_TRACK" => ProjectsV2StatusUpdateStatus.OFFTRACK,
                "COMPLETE" => ProjectsV2StatusUpdateStatus.COMPLETE,
                _ => null,
            };
        }
    }
}