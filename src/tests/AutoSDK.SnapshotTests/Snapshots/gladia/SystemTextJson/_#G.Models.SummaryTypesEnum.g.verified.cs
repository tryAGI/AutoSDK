//HintName: G.Models.SummaryTypesEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of summarization to apply
    /// </summary>
    public enum SummaryTypesEnum
    {
        /// <summary>
        /// 
        /// </summary>
        BulletPoints,
        /// <summary>
        /// 
        /// </summary>
        Concise,
        /// <summary>
        /// 
        /// </summary>
        General,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SummaryTypesEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SummaryTypesEnum value)
        {
            return value switch
            {
                SummaryTypesEnum.BulletPoints => "bullet_points",
                SummaryTypesEnum.Concise => "concise",
                SummaryTypesEnum.General => "general",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SummaryTypesEnum? ToEnum(string value)
        {
            return value switch
            {
                "bullet_points" => SummaryTypesEnum.BulletPoints,
                "concise" => SummaryTypesEnum.Concise,
                "general" => SummaryTypesEnum.General,
                _ => null,
            };
        }
    }
}