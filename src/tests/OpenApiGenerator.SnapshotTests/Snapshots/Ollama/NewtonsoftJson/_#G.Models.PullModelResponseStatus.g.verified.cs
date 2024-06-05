//HintName: G.Models.PullModelResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PullModelResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pulling manifest")]
        PullingManifest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="downloading digestname")]
        DownloadingDigestname,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PullModelResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullModelResponseStatus value)
        {
            return value switch
            {
                PullModelResponseStatus.PullingManifest => "pulling manifest",
                PullModelResponseStatus.DownloadingDigestname => "downloading digestname",
                PullModelResponseStatus.VerifyingSha256Digest => "verifying sha256 digest",
                PullModelResponseStatus.WritingManifest => "writing manifest",
                PullModelResponseStatus.RemovingAnyUnusedLayers => "removing any unused layers",
                PullModelResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullModelResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "pulling manifest" => PullModelResponseStatus.PullingManifest,
                "downloading digestname" => PullModelResponseStatus.DownloadingDigestname,
                "verifying sha256 digest" => PullModelResponseStatus.VerifyingSha256Digest,
                "writing manifest" => PullModelResponseStatus.WritingManifest,
                "removing any unused layers" => PullModelResponseStatus.RemovingAnyUnusedLayers,
                "success" => PullModelResponseStatus.Success,
                _ => null,
            };
        }
    }
}