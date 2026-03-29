//HintName: G.Models.CreatePieInsightFromCallTableDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the Insight.<br/>
    /// It is required to be `pie` to create a pie insight.
    /// </summary>
    public enum CreatePieInsightFromCallTableDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        Pie,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatePieInsightFromCallTableDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePieInsightFromCallTableDTOType value)
        {
            return value switch
            {
                CreatePieInsightFromCallTableDTOType.Pie => "pie",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePieInsightFromCallTableDTOType? ToEnum(string value)
        {
            return value switch
            {
                "pie" => CreatePieInsightFromCallTableDTOType.Pie,
                _ => null,
            };
        }
    }
}