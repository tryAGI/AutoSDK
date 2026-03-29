//HintName: G.Models.ResearchDtoClassVariant3Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchDtoClassVariant3Status
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchDtoClassVariant3StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassVariant3Status value)
        {
            return value switch
            {
                ResearchDtoClassVariant3Status.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassVariant3Status? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResearchDtoClassVariant3Status.Completed,
                _ => null,
            };
        }
    }
}