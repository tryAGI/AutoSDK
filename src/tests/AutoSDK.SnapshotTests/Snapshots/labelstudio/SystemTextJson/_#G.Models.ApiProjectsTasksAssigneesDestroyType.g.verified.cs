//HintName: G.Models.ApiProjectsTasksAssigneesDestroyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiProjectsTasksAssigneesDestroyType
    {
        /// <summary>
        /// 
        /// </summary>
        An,
        /// <summary>
        /// 
        /// </summary>
        Re,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiProjectsTasksAssigneesDestroyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiProjectsTasksAssigneesDestroyType value)
        {
            return value switch
            {
                ApiProjectsTasksAssigneesDestroyType.An => "AN",
                ApiProjectsTasksAssigneesDestroyType.Re => "RE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiProjectsTasksAssigneesDestroyType? ToEnum(string value)
        {
            return value switch
            {
                "AN" => ApiProjectsTasksAssigneesDestroyType.An,
                "RE" => ApiProjectsTasksAssigneesDestroyType.Re,
                _ => null,
            };
        }
    }
}