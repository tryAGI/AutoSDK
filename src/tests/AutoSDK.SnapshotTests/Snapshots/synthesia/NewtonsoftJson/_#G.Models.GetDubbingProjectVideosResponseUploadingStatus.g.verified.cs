//HintName: G.Models.GetDubbingProjectVideosResponseUploadingStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the dubbed video.<br/>
    /// Default Value: uploading
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetDubbingProjectVideosResponseUploadingStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uploading")]
        Uploading,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDubbingProjectVideosResponseUploadingStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDubbingProjectVideosResponseUploadingStatus value)
        {
            return value switch
            {
                GetDubbingProjectVideosResponseUploadingStatus.Uploading => "uploading",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDubbingProjectVideosResponseUploadingStatus? ToEnum(string value)
        {
            return value switch
            {
                "uploading" => GetDubbingProjectVideosResponseUploadingStatus.Uploading,
                _ => null,
            };
        }
    }
}