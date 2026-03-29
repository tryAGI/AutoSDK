//HintName: G.Models.AnnotatedEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `only` - only<br/>
    /// * `exclude` - exclude<br/>
    /// * `None` - None
    /// </summary>
    public enum AnnotatedEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Exclude,
        /// <summary>
        /// 
        /// </summary>
        Only,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnnotatedEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotatedEnum value)
        {
            return value switch
            {
                AnnotatedEnum.Exclude => "exclude",
                AnnotatedEnum.Only => "only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotatedEnum? ToEnum(string value)
        {
            return value switch
            {
                "exclude" => AnnotatedEnum.Exclude,
                "only" => AnnotatedEnum.Only,
                _ => null,
            };
        }
    }
}