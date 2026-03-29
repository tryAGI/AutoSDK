//HintName: G.Models.CreateDubbingProjectApiRequestFromSourceAssetIdVideoDuration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The duration of the video to create.<br/>
    /// Default Value: adaptive<br/>
    /// Example: adaptive
    /// </summary>
    public enum CreateDubbingProjectApiRequestFromSourceAssetIdVideoDuration
    {
        /// <summary>
        /// 
        /// </summary>
        Adaptive,
        /// <summary>
        /// 
        /// </summary>
        Original,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDubbingProjectApiRequestFromSourceAssetIdVideoDurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDubbingProjectApiRequestFromSourceAssetIdVideoDuration value)
        {
            return value switch
            {
                CreateDubbingProjectApiRequestFromSourceAssetIdVideoDuration.Adaptive => "adaptive",
                CreateDubbingProjectApiRequestFromSourceAssetIdVideoDuration.Original => "original",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDubbingProjectApiRequestFromSourceAssetIdVideoDuration? ToEnum(string value)
        {
            return value switch
            {
                "adaptive" => CreateDubbingProjectApiRequestFromSourceAssetIdVideoDuration.Adaptive,
                "original" => CreateDubbingProjectApiRequestFromSourceAssetIdVideoDuration.Original,
                _ => null,
            };
        }
    }
}