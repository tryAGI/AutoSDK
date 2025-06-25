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
    public static class CodeScanningAlertStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningAlertState value)
        {
            return value switch
            {
                CodeScanningAlertState.Open => "open",
                CodeScanningAlertState.Dismissed => "dismissed",
                CodeScanningAlertState.Fixed => "fixed",
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
                "open" => CodeScanningAlertState.Open,
                "dismissed" => CodeScanningAlertState.Dismissed,
                "fixed" => CodeScanningAlertState.Fixed,
                _ => null,
            };
        }
    }
}