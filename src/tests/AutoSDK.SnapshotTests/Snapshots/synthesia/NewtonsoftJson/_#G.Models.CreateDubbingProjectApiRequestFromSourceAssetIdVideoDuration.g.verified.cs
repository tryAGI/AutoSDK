//HintName: G.Models.CreateDubbingProjectApiRequestFromSourceAssetIdVideoDuration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The duration of the video to create.<br/>
    /// Default Value: adaptive<br/>
    /// Example: adaptive
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateDubbingProjectApiRequestFromSourceAssetIdVideoDuration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="adaptive")]
        Adaptive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="original")]
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