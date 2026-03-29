//HintName: G.Models.BashToolWithToolCallSubType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The sub type of tool.
    /// </summary>
    public enum BashToolWithToolCallSubType
    {
        /// <summary>
        /// 
        /// </summary>
        Bash20241022,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BashToolWithToolCallSubTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BashToolWithToolCallSubType value)
        {
            return value switch
            {
                BashToolWithToolCallSubType.Bash20241022 => "bash_20241022",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BashToolWithToolCallSubType? ToEnum(string value)
        {
            return value switch
            {
                "bash_20241022" => BashToolWithToolCallSubType.Bash20241022,
                _ => null,
            };
        }
    }
}