//HintName: G.Models.WebhookCreateRefType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of Git ref object created in the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCreateRefType
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