//HintName: G.Models.CreateImageEditRequestSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The size of the generated images. Must be one of `256x256`, `512x512`, or `1024x1024`.
    /// <br/>Default Value: 1024x1024
    /// <br/>Example: 1024x1024
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateImageEditRequestSize
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="256x256")]
        _256x256,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="512x512")]
        _512x512,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1024x1024")]
        _1024x1024,
    }
}