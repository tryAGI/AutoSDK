//HintName: G.Models.CreateImageEditRequestResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format in which the generated images are returned. Must be one of `url` or `b64_json`. URLs are only valid for 60 minutes after the image has been generated.
    /// <br/>Default Value: url
    /// <br/>Example: url
    /// </summary>
    public abstract class CreateImageEditRequestResponseFormat
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