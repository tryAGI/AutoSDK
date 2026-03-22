//HintName: G.Models.PullModelStatusEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PullModelStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="downloading digestname")]
        DownloadingDigestname,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pulling manifest")]
        PullingManifest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="removing any unused layers")]
        RemovingAnyUnusedLayers,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="verifying sha256 digest")]
        VerifyingSha256Digest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="writing manifest")]
        WritingManifest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PullModelStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullModelStatusEnum value)
        {
            return value switch
            {
                PullModelStatusEnum.DownloadingDigestname => "downloading digestname",
                PullModelStatusEnum.PullingManifest => "pulling manifest",
                PullModelStatusEnum.RemovingAnyUnusedLayers => "removing any unused layers",
                PullModelStatusEnum.Success => "success",
                PullModelStatusEnum.VerifyingSha256Digest => "verifying sha256 digest",
                PullModelStatusEnum.WritingManifest => "writing manifest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullModelStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "downloading digestname" => PullModelStatusEnum.DownloadingDigestname,
                "pulling manifest" => PullModelStatusEnum.PullingManifest,
                "removing any unused layers" => PullModelStatusEnum.RemovingAnyUnusedLayers,
                "success" => PullModelStatusEnum.Success,
                "verifying sha256 digest" => PullModelStatusEnum.VerifyingSha256Digest,
                "writing manifest" => PullModelStatusEnum.WritingManifest,
                _ => null,
            };
        }
    }
}