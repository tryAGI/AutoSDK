//HintName: G.Models.VectorStoreExpirationAfterAnchor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Anchor timestamp after which the expiration policy applies. Supported anchors: `last_active_at`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VectorStoreExpirationAfterAnchor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="last_active_at")]
        LastActiveAt,
    }
}