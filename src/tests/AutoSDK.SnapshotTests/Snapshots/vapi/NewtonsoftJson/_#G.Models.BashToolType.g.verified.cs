//HintName: G.Models.BashToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "bash" for Bash tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BashToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bash")]
        Bash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BashToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BashToolType value)
        {
            return value switch
            {
                BashToolType.Bash => "bash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BashToolType? ToEnum(string value)
        {
            return value switch
            {
                "bash" => BashToolType.Bash,
                _ => null,
            };
        }
    }
}