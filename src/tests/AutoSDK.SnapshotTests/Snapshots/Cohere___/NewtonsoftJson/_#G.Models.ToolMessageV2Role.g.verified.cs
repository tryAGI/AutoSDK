//HintName: G.Models.ToolMessageV2Role.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolMessageV2Role
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolMessageV2RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolMessageV2Role value)
        {
            return value switch
            {
                ToolMessageV2Role.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolMessageV2Role? ToEnum(string value)
        {
            return value switch
            {
                "tool" => ToolMessageV2Role.Tool,
                _ => null,
            };
        }
    }
}