//HintName: G.Models.CreateImageRequestSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The size of the generated images. Must be one of `256x256`, `512x512`, or `1024x1024` for `dall-e-2`. Must be one of `1024x1024`, `1792x1024`, or `1024x1792` for `dall-e-3` models.
    /// <br/>Default Value: 1024x1024
    /// <br/>Example: 1024x1024
    /// </summary>
    public abstract class CreateImageRequestSize
    {
        /// <summary>
        /// 
        /// </summary>
        public const string _256x256 = "256x256";
        /// <summary>
        /// 
        /// </summary>
        public const string _512x512 = "512x512";
        /// <summary>
        /// 
        /// </summary>
        public const string _1024x1024 = "1024x1024";
        /// <summary>
        /// 
        /// </summary>
        public const string _1792x1024 = "1792x1024";
        /// <summary>
        /// 
        /// </summary>
        public const string _1024x1792 = "1024x1792";
    }
}