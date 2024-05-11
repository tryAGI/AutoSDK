//HintName: G.Models.PullModelResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status pulling the model.
    /// <br/>Example: pulling manifest
    /// </summary>
    public abstract class PullModelResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public const string PullingManifest = "pulling manifest";
        /// <summary>
        /// 
        /// </summary>
        public const string DownloadingDigestname = "downloading digestname";
        /// <summary>
        /// 
        /// </summary>
        public const string VerifyingSha256Digest = "verifying sha256 digest";
        /// <summary>
        /// 
        /// </summary>
        public const string WritingManifest = "writing manifest";
        /// <summary>
        /// 
        /// </summary>
        public const string RemovingAnyUnusedLayers = "removing any unused layers";
        /// <summary>
        /// 
        /// </summary>
        public const string Success = "success";
    }
}