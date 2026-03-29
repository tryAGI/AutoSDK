//HintName: G.Models.ToolResultOutputVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolResultOutputVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json")]
        Json,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolResultOutputVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolResultOutputVariant2Type value)
        {
            return value switch
            {
                ToolResultOutputVariant2Type.Json => "json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolResultOutputVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "json" => ToolResultOutputVariant2Type.Json,
                _ => null,
            };
        }
    }
}