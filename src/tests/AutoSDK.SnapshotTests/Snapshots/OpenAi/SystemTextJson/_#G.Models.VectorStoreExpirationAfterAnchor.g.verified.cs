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
        /// `last_active_at`.
        /// </summary>
        LastActiveAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorStoreExpirationAfterAnchorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorStoreExpirationAfterAnchor value)
        {
            return value switch
            {
                VectorStoreExpirationAfterAnchor.LastActiveAt => "last_active_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStoreExpirationAfterAnchor? ToEnum(string value)
        {
            return value switch
            {
                "last_active_at" => VectorStoreExpirationAfterAnchor.LastActiveAt,
                _ => null,
            };
        }
    }
}