//HintName: G.Models.MakeToolWithToolCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "make" for Make tool.
    /// </summary>
    public enum MakeToolWithToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        Make,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MakeToolWithToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MakeToolWithToolCallType value)
        {
            return value switch
            {
                MakeToolWithToolCallType.Make => "make",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MakeToolWithToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "make" => MakeToolWithToolCallType.Make,
                _ => null,
            };
        }
    }
}