//HintName: G.Models.ProjectCreationMetaResponseModelStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the project creation action.
    /// </summary>
    public enum ProjectCreationMetaResponseModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Creating,
        /// <summary>
        /// 
        /// </summary>
        Finished,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectCreationMetaResponseModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectCreationMetaResponseModelStatus value)
        {
            return value switch
            {
                ProjectCreationMetaResponseModelStatus.Pending => "pending",
                ProjectCreationMetaResponseModelStatus.Creating => "creating",
                ProjectCreationMetaResponseModelStatus.Finished => "finished",
                ProjectCreationMetaResponseModelStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectCreationMetaResponseModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => ProjectCreationMetaResponseModelStatus.Pending,
                "creating" => ProjectCreationMetaResponseModelStatus.Creating,
                "finished" => ProjectCreationMetaResponseModelStatus.Finished,
                "failed" => ProjectCreationMetaResponseModelStatus.Failed,
                _ => null,
            };
        }
    }
}