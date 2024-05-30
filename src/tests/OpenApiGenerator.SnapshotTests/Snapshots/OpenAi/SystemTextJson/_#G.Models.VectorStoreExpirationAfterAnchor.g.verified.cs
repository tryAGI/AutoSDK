//HintName: G.Models.VectorStoreExpirationAfterAnchor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Anchor timestamp after which the expiration policy applies. Supported anchors: `last_active_at`.
    /// </summary>
    public enum VectorStoreExpirationAfterAnchor
    {
        /// <summary>
        /// 
        /// </summary>
        LastActiveAt,
    }

    public static class VectorStoreExpirationAfterAnchorExtensions
    {
        public static string ToValueString(this VectorStoreExpirationAfterAnchor value)
        {
            return value switch
            {
                VectorStoreExpirationAfterAnchor.LastActiveAt => "last_active_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static VectorStoreExpirationAfterAnchor ToEnum(string value)
        {
            return value switch
            {
                "last_active_at" => VectorStoreExpirationAfterAnchor.LastActiveAt,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static VectorStoreExpirationAfterAnchor ToEnum(int value)
        {
            return value switch
            {
                0 => VectorStoreExpirationAfterAnchor.LastActiveAt,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}