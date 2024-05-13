//HintName: G.Models.CreateImageRequestQuality.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The quality of the image that will be generated. `hd` creates images with finer details and greater consistency across the image. This param is only supported for `dall-e-3`.
    /// <br/>Default Value: standard
    /// <br/>Example: standard
    /// </summary>
    public abstract class CreateImageRequestQuality
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Standard = "standard";
        /// <summary>
        /// 
        /// </summary>
        public const string Hd = "hd";
    }
}