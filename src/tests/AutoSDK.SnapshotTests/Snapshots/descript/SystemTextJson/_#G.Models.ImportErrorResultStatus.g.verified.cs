//HintName: G.Models.ImportErrorResultStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Job failed completely<br/>
    /// Example: error
    /// </summary>
    public enum ImportErrorResultStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImportErrorResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportErrorResultStatus value)
        {
            return value switch
            {
                ImportErrorResultStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportErrorResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => ImportErrorResultStatus.Error,
                _ => null,
            };
        }
    }
}