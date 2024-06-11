//HintName: G.Models.PullModelStatusVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PullModelStatusVariant1
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
    public static class PullModelStatusVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullModelStatusVariant1 value)
        {
            return value switch
            {
                PullModelStatusVariant1.PullingManifest => "pulling manifest",
                PullModelStatusVariant1.DownloadingDigestname => "downloading digestname",
                PullModelStatusVariant1.VerifyingSha256Digest => "verifying sha256 digest",
                PullModelStatusVariant1.WritingManifest => "writing manifest",
                PullModelStatusVariant1.RemovingAnyUnusedLayers => "removing any unused layers",
                PullModelStatusVariant1.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullModelStatusVariant1? ToEnum(string value)
        {
            return value switch
            {
                "pulling manifest" => PullModelStatusVariant1.PullingManifest,
                "downloading digestname" => PullModelStatusVariant1.DownloadingDigestname,
                "verifying sha256 digest" => PullModelStatusVariant1.VerifyingSha256Digest,
                "writing manifest" => PullModelStatusVariant1.WritingManifest,
                "removing any unused layers" => PullModelStatusVariant1.RemovingAnyUnusedLayers,
                "success" => PullModelStatusVariant1.Success,
                _ => null,
            };
        }
    }
}