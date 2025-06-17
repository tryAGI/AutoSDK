//HintName: G.Models.SegmentedJsonExportOptionsFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SegmentedJsonExportOptionsFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="segmented_json")]
        SegmentedJson,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SegmentedJsonExportOptionsFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SegmentedJsonExportOptionsFormat value)
        {
            return value switch
            {
                SegmentedJsonExportOptionsFormat.SegmentedJson => "segmented_json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SegmentedJsonExportOptionsFormat? ToEnum(string value)
        {
            return value switch
            {
                "segmented_json" => SegmentedJsonExportOptionsFormat.SegmentedJson,
                _ => null,
            };
        }
    }
}