//HintName: G.Models.CreateEmbeddingRequestEncodingFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format to return the embeddings in. Can be either `float` or [`base64`](https://pypi.org/project/pybase64/).
    /// <br/>Default Value: float
    /// <br/>Example: float
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateEmbeddingRequestEncodingFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="float")]
        Float,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="base64")]
        Base64,
    }
}