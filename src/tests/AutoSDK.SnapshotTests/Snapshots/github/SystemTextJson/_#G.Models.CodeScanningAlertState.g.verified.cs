//HintName: G.Models.CodeScanningAlertState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of a code scanning alert.
    /// </summary>
    public enum CodeScanningAlertState
    {
        /// <summary>
        /// 
        /// </summary>
        Dismissed,
        /// <summary>
        /// 
        /// </summary>
        Fixed,
        /// <summary>
        /// 
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningAlertStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningAlertState value)
        {
            return value switch
            {
                CodeScanningAlertState.Dismissed => "dismissed",
                CodeScanningAlertState.Fixed => "fixed",
                CodeScanningAlertState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningAlertState? ToEnum(string value)
        {
            return value switch
            {
                "dismissed" => CodeScanningAlertState.Dismissed,
                "fixed" => CodeScanningAlertState.Fixed,
                "open" => CodeScanningAlertState.Open,
                _ => null,
            };
        }
    }
}