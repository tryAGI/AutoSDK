//HintName: G.Models.PullModelResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status pulling the model.
    /// <br/>Example: pulling manifest
    /// </summary>
    public enum PullModelResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        PullingManifest,
        /// <summary>
        /// 
        /// </summary>
        DownloadingDigestname,
        /// <summary>
        /// 
        /// </summary>
        VerifyingSha256Digest,
        /// <summary>
        /// 
        /// </summary>
        WritingManifest,
        /// <summary>
        /// 
        /// </summary>
        RemovingAnyUnusedLayers,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    public static class PullModelResponseStatusExtensions
    {
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
        public static PullModelResponseStatus ToEnum(string value)
        {
            return value switch
            {
                "pulling manifest" => PullModelResponseStatus.PullingManifest,
                "downloading digestname" => PullModelResponseStatus.DownloadingDigestname,
                "verifying sha256 digest" => PullModelResponseStatus.VerifyingSha256Digest,
                "writing manifest" => PullModelResponseStatus.WritingManifest,
                "removing any unused layers" => PullModelResponseStatus.RemovingAnyUnusedLayers,
                "success" => PullModelResponseStatus.Success,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static PullModelResponseStatus ToEnum(int value)
        {
            return value switch
            {
                0 => PullModelResponseStatus.PullingManifest,
                1 => PullModelResponseStatus.DownloadingDigestname,
                2 => PullModelResponseStatus.VerifyingSha256Digest,
                3 => PullModelResponseStatus.WritingManifest,
                4 => PullModelResponseStatus.RemovingAnyUnusedLayers,
                5 => PullModelResponseStatus.Success,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}