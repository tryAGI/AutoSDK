//HintName: G.Models.CodeScanningListAlertsForRepoState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of a code scanning alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningListAlertsForRepoState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dismissed")]
        Dismissed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fixed")]
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningListAlertsForRepoStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningListAlertsForRepoState value)
        {
            return value switch
            {
                CodeScanningListAlertsForRepoState.Open => "open",
                CodeScanningListAlertsForRepoState.Closed => "closed",
                CodeScanningListAlertsForRepoState.Dismissed => "dismissed",
                CodeScanningListAlertsForRepoState.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningListAlertsForRepoState ToEnum(string value)
        {
            return value switch
            {
                "open" => CodeScanningListAlertsForRepoState.Open,
                "closed" => CodeScanningListAlertsForRepoState.Closed,
                "dismissed" => CodeScanningListAlertsForRepoState.Dismissed,
                "fixed" => CodeScanningListAlertsForRepoState.Fixed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}