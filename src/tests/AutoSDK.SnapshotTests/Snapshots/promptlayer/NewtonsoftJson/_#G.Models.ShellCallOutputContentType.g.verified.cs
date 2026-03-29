//HintName: G.Models.ShellCallOutputContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: shell_call_output
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ShellCallOutputContentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shell_call_output")]
        ShellCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShellCallOutputContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShellCallOutputContentType value)
        {
            return value switch
            {
                ShellCallOutputContentType.ShellCallOutput => "shell_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShellCallOutputContentType? ToEnum(string value)
        {
            return value switch
            {
                "shell_call_output" => ShellCallOutputContentType.ShellCallOutput,
                _ => null,
            };
        }
    }
}