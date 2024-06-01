//HintName: G.Models.CodeScanningAlertItemsState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of a code scanning alert.
    /// </summary>
    public enum CodeScanningAlertItemsState
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
    public static class CodeScanningAlertItemsStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningAlertItemsState value)
        {
            return value switch
            {
                CodeScanningAlertItemsState.Open => "open",
                CodeScanningAlertItemsState.Dismissed => "dismissed",
                CodeScanningAlertItemsState.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningAlertItemsState ToEnum(string value)
        {
            return value switch
            {
                "open" => CodeScanningAlertItemsState.Open,
                "dismissed" => CodeScanningAlertItemsState.Dismissed,
                "fixed" => CodeScanningAlertItemsState.Fixed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}