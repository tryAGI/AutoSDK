//HintName: G.Models.LegacyJobMetadataOutObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: job.metadata
    /// </summary>
    public enum LegacyJobMetadataOutObject
    {
        /// <summary>
        /// 
        /// </summary>
        JobMetadata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LegacyJobMetadataOutObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LegacyJobMetadataOutObject value)
        {
            return value switch
            {
                LegacyJobMetadataOutObject.JobMetadata => "job.metadata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LegacyJobMetadataOutObject? ToEnum(string value)
        {
            return value switch
            {
                "job.metadata" => LegacyJobMetadataOutObject.JobMetadata,
                _ => null,
            };
        }
    }
}