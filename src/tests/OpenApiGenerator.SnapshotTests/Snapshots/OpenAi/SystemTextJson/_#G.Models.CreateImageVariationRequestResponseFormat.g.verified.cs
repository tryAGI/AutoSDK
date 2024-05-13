//HintName: G.Models.CreateImageVariationRequestResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format in which the generated images are returned. Must be one of `url` or `b64_json`.
    /// <br/>Default Value: url
    /// <br/>Example: url
    /// </summary>
    public abstract class CreateImageVariationRequestResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Url = "url";
        /// <summary>
        /// 
        /// </summary>
        public const string B64Json = "b64_json";
    }
}