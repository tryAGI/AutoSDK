//HintName: G.Models.UpdateToolRequestDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateToolRequestDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lambda")]
        Lambda,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mcp")]
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateToolRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateToolRequestDiscriminatorType value)
        {
            return value switch
            {
                UpdateToolRequestDiscriminatorType.Lambda => "lambda",
                UpdateToolRequestDiscriminatorType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateToolRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "lambda" => UpdateToolRequestDiscriminatorType.Lambda,
                "mcp" => UpdateToolRequestDiscriminatorType.Mcp,
                _ => null,
            };
        }
    }
}