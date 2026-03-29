//HintName: G.Models.BashToolSubType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The sub type of tool.
    /// </summary>
    public enum BashToolSubType
    {
        /// <summary>
        /// 
        /// </summary>
        Bash20241022,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BashToolSubTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BashToolSubType value)
        {
            return value switch
            {
                BashToolSubType.Bash20241022 => "bash_20241022",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BashToolSubType? ToEnum(string value)
        {
            return value switch
            {
                "bash_20241022" => BashToolSubType.Bash20241022,
                _ => null,
            };
        }
    }
}