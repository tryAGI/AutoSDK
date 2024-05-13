//HintName: G.Models.MessageDeltaContentImageUrlObjectImageUrlDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the detail level of the image. `low` uses fewer tokens, you can opt in to high resolution using `high`.
    /// <br/>Default Value: auto
    /// </summary>
    public abstract class MessageDeltaContentImageUrlObjectImageUrlDetail
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Auto = "auto";
        /// <summary>
        /// 
        /// </summary>
        public const string Low = "low";
        /// <summary>
        /// 
        /// </summary>
        public const string High = "high";
    }
}