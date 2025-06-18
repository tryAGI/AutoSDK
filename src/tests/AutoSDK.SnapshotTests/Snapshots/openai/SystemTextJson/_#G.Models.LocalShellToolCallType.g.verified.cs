//HintName: G.Models.LocalShellToolCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the local shell call. Always `local_shell_call`.
    /// </summary>
    public enum LocalShellToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        LocalShellCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LocalShellToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalShellToolCallType value)
        {
            return value switch
            {
                LocalShellToolCallType.LocalShellCall => "local_shell_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalShellToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "local_shell_call" => LocalShellToolCallType.LocalShellCall,
                _ => null,
            };
        }
    }
}