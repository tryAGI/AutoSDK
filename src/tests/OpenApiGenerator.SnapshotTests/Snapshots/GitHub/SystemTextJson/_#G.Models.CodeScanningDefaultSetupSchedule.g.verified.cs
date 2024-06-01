//HintName: G.Models.CodeScanningDefaultSetupSchedule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The frequency of the periodic analysis.
    /// </summary>
    public enum CodeScanningDefaultSetupSchedule
    {
        /// <summary>
        /// 
        /// </summary>
        Weekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningDefaultSetupScheduleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningDefaultSetupSchedule value)
        {
            return value switch
            {
                CodeScanningDefaultSetupSchedule.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningDefaultSetupSchedule ToEnum(string value)
        {
            return value switch
            {
                "weekly" => CodeScanningDefaultSetupSchedule.Weekly,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}