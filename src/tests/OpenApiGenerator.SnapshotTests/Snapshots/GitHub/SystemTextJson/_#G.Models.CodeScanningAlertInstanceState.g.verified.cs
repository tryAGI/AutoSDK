//HintName: G.Models.CodeScanningAlertInstanceState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of a code scanning alert.
    /// </summary>
    public enum CodeScanningAlertInstanceState
    {
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Dismissed,
        /// <summary>
        /// 
        /// </summary>
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningAlertInstanceStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningAlertInstanceState value)
        {
            return value switch
            {
                CodeScanningAlertInstanceState.Open => "open",
                CodeScanningAlertInstanceState.Dismissed => "dismissed",
                CodeScanningAlertInstanceState.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningAlertInstanceState ToEnum(string value)
        {
            return value switch
            {
                "open" => CodeScanningAlertInstanceState.Open,
                "dismissed" => CodeScanningAlertInstanceState.Dismissed,
                "fixed" => CodeScanningAlertInstanceState.Fixed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}