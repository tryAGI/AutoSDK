//HintName: G.Models.ShellCallContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: shell_call
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ShellCallContentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shell_call")]
        ShellCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShellCallContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShellCallContentType value)
        {
            return value switch
            {
                ShellCallContentType.ShellCall => "shell_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShellCallContentType? ToEnum(string value)
        {
            return value switch
            {
                "shell_call" => ShellCallContentType.ShellCall,
                _ => null,
            };
        }
    }
}