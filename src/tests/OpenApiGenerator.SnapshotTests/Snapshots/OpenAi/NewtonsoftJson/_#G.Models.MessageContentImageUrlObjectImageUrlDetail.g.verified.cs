//HintName: G.Models.MessageContentImageUrlObjectImageUrlDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the detail level of the image. `low` uses fewer tokens, you can opt in to high resolution using `high`. Default value is `auto`
    /// <br/>Default Value: auto
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageContentImageUrlObjectImageUrlDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
    }
}