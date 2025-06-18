//HintName: G.Models.LocalShellExecActionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the local shell action. Always `exec`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LocalShellExecActionType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="exec")]
        Exec,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LocalShellExecActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalShellExecActionType value)
        {
            return value switch
            {
                LocalShellExecActionType.Exec => "exec",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalShellExecActionType? ToEnum(string value)
        {
            return value switch
            {
                "exec" => LocalShellExecActionType.Exec,
                _ => null,
            };
        }
    }
}