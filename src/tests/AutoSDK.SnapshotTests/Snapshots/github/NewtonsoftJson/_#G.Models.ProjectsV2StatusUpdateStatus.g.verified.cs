//HintName: G.Models.ProjectsV2StatusUpdateStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectsV2StatusUpdateStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AT_RISK")]
        AtRisk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMPLETE")]
        Complete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INACTIVE")]
        Inactive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OFF_TRACK")]
        OffTrack,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ON_TRACK")]
        OnTrack,
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
                ProjectsV2StatusUpdateStatus.AtRisk => "AT_RISK",
                ProjectsV2StatusUpdateStatus.Complete => "COMPLETE",
                ProjectsV2StatusUpdateStatus.Inactive => "INACTIVE",
                ProjectsV2StatusUpdateStatus.OffTrack => "OFF_TRACK",
                ProjectsV2StatusUpdateStatus.OnTrack => "ON_TRACK",
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
                "AT_RISK" => ProjectsV2StatusUpdateStatus.AtRisk,
                "COMPLETE" => ProjectsV2StatusUpdateStatus.Complete,
                "INACTIVE" => ProjectsV2StatusUpdateStatus.Inactive,
                "OFF_TRACK" => ProjectsV2StatusUpdateStatus.OffTrack,
                "ON_TRACK" => ProjectsV2StatusUpdateStatus.OnTrack,
                _ => null,
            };
        }
    }
}