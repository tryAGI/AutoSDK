//HintName: G.Models.LocalShellToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the local shell tool. Always `local_shell`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LocalShellToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="local_shell")]
        LocalShell,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LocalShellToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalShellToolType value)
        {
            return value switch
            {
                LocalShellToolType.LocalShell => "local_shell",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalShellToolType? ToEnum(string value)
        {
            return value switch
            {
                "local_shell" => LocalShellToolType.LocalShell,
                _ => null,
            };
        }
    }
}