//HintName: G.Models.PatchProjectAutomationConfigVariant2Format.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format to export the results in
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PatchProjectAutomationConfigVariant2Format
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="jsonl")]
        Jsonl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parquet")]
        Parquet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchProjectAutomationConfigVariant2FormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchProjectAutomationConfigVariant2Format value)
        {
            return value switch
            {
                PatchProjectAutomationConfigVariant2Format.Jsonl => "jsonl",
                PatchProjectAutomationConfigVariant2Format.Parquet => "parquet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchProjectAutomationConfigVariant2Format? ToEnum(string value)
        {
            return value switch
            {
                "jsonl" => PatchProjectAutomationConfigVariant2Format.Jsonl,
                "parquet" => PatchProjectAutomationConfigVariant2Format.Parquet,
                _ => null,
            };
        }
    }
}