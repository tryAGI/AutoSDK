//HintName: G.Models.ResearchDtoClassVariant2Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchDtoClassVariant2Status
    {
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchDtoClassVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassVariant2Status value)
        {
            return value switch
            {
                ResearchDtoClassVariant2Status.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "running" => ResearchDtoClassVariant2Status.Running,
                _ => null,
            };
        }
    }
}