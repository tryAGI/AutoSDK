//HintName: G.Models.WebhookDeleteRefType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of Git ref object deleted in the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeleteRefType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tag")]
        Tag,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="branch")]
        Branch,
    }
}