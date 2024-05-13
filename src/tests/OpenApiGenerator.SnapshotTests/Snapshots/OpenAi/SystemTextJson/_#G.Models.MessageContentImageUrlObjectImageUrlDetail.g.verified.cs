//HintName: G.Models.MessageContentImageUrlObjectImageUrlDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the detail level of the image. `low` uses fewer tokens, you can opt in to high resolution using `high`. Default value is `auto`
    /// <br/>Default Value: auto
    /// </summary>
    public abstract class MessageContentImageUrlObjectImageUrlDetail
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