//HintName: G.Models.CodeScanningUpdateAlertRequestState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sets the state of the code scanning alert. You must provide `dismissed_reason` when you set the state to `dismissed`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningUpdateAlertRequestState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dismissed")]
        Dismissed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningUpdateAlertRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningUpdateAlertRequestState value)
        {
            return value switch
            {
                CodeScanningUpdateAlertRequestState.Open => "open",
                CodeScanningUpdateAlertRequestState.Dismissed => "dismissed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningUpdateAlertRequestState ToEnum(string value)
        {
            return value switch
            {
                "open" => CodeScanningUpdateAlertRequestState.Open,
                "dismissed" => CodeScanningUpdateAlertRequestState.Dismissed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}