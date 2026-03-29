//HintName: G.Models.ParsePlanLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for the Parse plan level.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ParsePlanLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DEFAULT")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PREMIUM")]
        Premium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParsePlanLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParsePlanLevel value)
        {
            return value switch
            {
                ParsePlanLevel.Default => "DEFAULT",
                ParsePlanLevel.Premium => "PREMIUM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParsePlanLevel? ToEnum(string value)
        {
            return value switch
            {
                "DEFAULT" => ParsePlanLevel.Default,
                "PREMIUM" => ParsePlanLevel.Premium,
                _ => null,
            };
        }
    }
}