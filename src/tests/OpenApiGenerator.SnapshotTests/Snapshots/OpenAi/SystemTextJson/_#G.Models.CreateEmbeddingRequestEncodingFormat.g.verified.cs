//HintName: G.Models.CreateEmbeddingRequestEncodingFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format to return the embeddings in. Can be either `float` or [`base64`](https://pypi.org/project/pybase64/).
    /// <br/>Default Value: float
    /// <br/>Example: float
    /// </summary>
    public abstract class CreateEmbeddingRequestEncodingFormat
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Float = "float";
        /// <summary>
        /// 
        /// </summary>
        public const string Base64 = "base64";
    }
}