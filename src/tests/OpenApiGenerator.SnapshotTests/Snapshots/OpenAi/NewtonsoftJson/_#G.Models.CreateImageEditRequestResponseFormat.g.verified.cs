//HintName: G.Models.CreateImageEditRequestResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format in which the generated images are returned. Must be one of `url` or `b64_json`.
    /// <br/>Default Value: url
    /// <br/>Example: url
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateImageEditRequestResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="url")]
        Url,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="b64_json")]
        B64Json,
    }
}