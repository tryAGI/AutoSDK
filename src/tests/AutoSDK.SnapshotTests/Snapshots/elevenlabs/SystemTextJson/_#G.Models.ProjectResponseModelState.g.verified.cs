//HintName: G.Models.ProjectResponseModelState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the project.
    /// </summary>
    public enum ProjectResponseModelState
    {
        /// <summary>
        /// 
        /// </summary>
        Converting,
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
        InQueue,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectResponseModelStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectResponseModelState value)
        {
            return value switch
            {
                ProjectResponseModelState.Converting => "converting",
                ProjectResponseModelState.Creating => "creating",
                ProjectResponseModelState.Default => "default",
                ProjectResponseModelState.InQueue => "in_queue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectResponseModelState? ToEnum(string value)
        {
            return value switch
            {
                "converting" => ProjectResponseModelState.Converting,
                "creating" => ProjectResponseModelState.Creating,
                "default" => ProjectResponseModelState.Default,
                "in_queue" => ProjectResponseModelState.InQueue,
                _ => null,
            };
        }
    }
}