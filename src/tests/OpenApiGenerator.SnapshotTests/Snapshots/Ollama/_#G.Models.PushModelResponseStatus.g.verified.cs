//HintName: G.Models.PushModelResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status pushing the model.
    /// </summary>
    public abstract class PushModelResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public const string RetrievingManifest = "retrieving manifest";
        /// <summary>
        /// 
        /// </summary>
        public const string StartingUpload = "starting upload";
        /// <summary>
        /// 
        /// </summary>
        public const string PushingManifest = "pushing manifest";
        /// <summary>
        /// 
        /// </summary>
        public const string Success = "success";
    }
}