//HintName: G.Models.FinishedEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `only` - only<br/>
    /// * `exclude` - exclude<br/>
    /// * `None` - None
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FinishedEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="exclude")]
        Exclude,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="only")]
        Only,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinishedEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinishedEnum value)
        {
            return value switch
            {
                FinishedEnum.Exclude => "exclude",
                FinishedEnum.Only => "only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinishedEnum? ToEnum(string value)
        {
            return value switch
            {
                "exclude" => FinishedEnum.Exclude,
                "only" => FinishedEnum.Only,
                _ => null,
            };
        }
    }
}