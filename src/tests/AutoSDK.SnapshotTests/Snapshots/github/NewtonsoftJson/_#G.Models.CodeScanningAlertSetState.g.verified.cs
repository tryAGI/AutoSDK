//HintName: G.Models.CodeScanningAlertSetState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sets the state of the code scanning alert. You must provide `dismissed_reason` when you set the state to `dismissed`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningAlertSetState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dismissed")]
        Dismissed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningAlertSetStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningAlertSetState value)
        {
            return value switch
            {
                CodeScanningAlertSetState.Dismissed => "dismissed",
                CodeScanningAlertSetState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningAlertSetState? ToEnum(string value)
        {
            return value switch
            {
                "dismissed" => CodeScanningAlertSetState.Dismissed,
                "open" => CodeScanningAlertSetState.Open,
                _ => null,
            };
        }
    }
}