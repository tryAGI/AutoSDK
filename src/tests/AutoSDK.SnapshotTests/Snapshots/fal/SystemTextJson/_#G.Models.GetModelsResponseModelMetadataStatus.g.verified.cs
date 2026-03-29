//HintName: G.Models.GetModelsResponseModelMetadataStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 'active' or 'deprecated'. Newest models are surfaced in Explore and may be flagged as 'new/beta' in tags
    /// </summary>
    public enum GetModelsResponseModelMetadataStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Deprecated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelsResponseModelMetadataStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsResponseModelMetadataStatus value)
        {
            return value switch
            {
                GetModelsResponseModelMetadataStatus.Active => "active",
                GetModelsResponseModelMetadataStatus.Deprecated => "deprecated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsResponseModelMetadataStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => GetModelsResponseModelMetadataStatus.Active,
                "deprecated" => GetModelsResponseModelMetadataStatus.Deprecated,
                _ => null,
            };
        }
    }
}