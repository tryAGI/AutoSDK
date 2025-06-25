//HintName: G.Models.ProjectExtendedResponseModelState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the project.
    /// </summary>
    public enum ProjectExtendedResponseModelState
    {
        /// <summary>
        /// 
        /// </summary>
        Creating,
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Converting,
        /// <summary>
        /// 
        /// </summary>
        InQueue,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectExtendedResponseModelStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectExtendedResponseModelState value)
        {
            return value switch
            {
                ProjectExtendedResponseModelState.Creating => "creating",
                ProjectExtendedResponseModelState.Default => "default",
                ProjectExtendedResponseModelState.Converting => "converting",
                ProjectExtendedResponseModelState.InQueue => "in_queue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectExtendedResponseModelState? ToEnum(string value)
        {
            return value switch
            {
                "creating" => ProjectExtendedResponseModelState.Creating,
                "default" => ProjectExtendedResponseModelState.Default,
                "converting" => ProjectExtendedResponseModelState.Converting,
                "in_queue" => ProjectExtendedResponseModelState.InQueue,
                _ => null,
            };
        }
    }
}