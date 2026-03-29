//HintName: G.Models.ApiProjectsTasksAssigneesCreateRequestType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Assignment type. Use AN for annotate or RE for review.
    /// </summary>
    public enum ApiProjectsTasksAssigneesCreateRequestType
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
    public static class ApiProjectsTasksAssigneesCreateRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiProjectsTasksAssigneesCreateRequestType value)
        {
            return value switch
            {
                ApiProjectsTasksAssigneesCreateRequestType.An => "AN",
                ApiProjectsTasksAssigneesCreateRequestType.Re => "RE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiProjectsTasksAssigneesCreateRequestType? ToEnum(string value)
        {
            return value switch
            {
                "AN" => ApiProjectsTasksAssigneesCreateRequestType.An,
                "RE" => ApiProjectsTasksAssigneesCreateRequestType.Re,
                _ => null,
            };
        }
    }
}