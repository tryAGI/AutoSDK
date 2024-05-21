//HintName: G.Models.PullModelResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status pulling the model.
    /// <br/>Example: pulling manifest
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
}