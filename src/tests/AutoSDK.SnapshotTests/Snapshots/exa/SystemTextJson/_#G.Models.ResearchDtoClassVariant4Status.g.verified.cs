//HintName: G.Models.ResearchDtoClassVariant4Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchDtoClassVariant4Status
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchDtoClassVariant4StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassVariant4Status value)
        {
            return value switch
            {
                ResearchDtoClassVariant4Status.Canceled => "canceled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassVariant4Status? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => ResearchDtoClassVariant4Status.Canceled,
                _ => null,
            };
        }
    }
}