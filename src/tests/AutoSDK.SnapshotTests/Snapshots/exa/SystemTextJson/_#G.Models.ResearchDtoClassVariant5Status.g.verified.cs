//HintName: G.Models.ResearchDtoClassVariant5Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchDtoClassVariant5Status
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchDtoClassVariant5StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassVariant5Status value)
        {
            return value switch
            {
                ResearchDtoClassVariant5Status.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassVariant5Status? ToEnum(string value)
        {
            return value switch
            {
                "failed" => ResearchDtoClassVariant5Status.Failed,
                _ => null,
            };
        }
    }
}