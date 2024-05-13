//HintName: G.Models.VectorStoreExpirationAfterAnchor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Anchor timestamp after which the expiration policy applies. Supported anchors: `last_active_at`.
    /// </summary>
    public abstract class VectorStoreExpirationAfterAnchor
    {
        /// <summary>
        /// 
        /// </summary>
        public const string LastActiveAt = "last_active_at";
    }
}