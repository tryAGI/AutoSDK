//HintName: G.Models.ContainerResourceExpiresAfterAnchor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reference point for the expiration.
    /// </summary>
    public enum ContainerResourceExpiresAfterAnchor
    {
        /// <summary>
        /// 
        /// </summary>
        LastActiveAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContainerResourceExpiresAfterAnchorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainerResourceExpiresAfterAnchor value)
        {
            return value switch
            {
                ContainerResourceExpiresAfterAnchor.LastActiveAt => "last_active_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainerResourceExpiresAfterAnchor? ToEnum(string value)
        {
            return value switch
            {
                "last_active_at" => ContainerResourceExpiresAfterAnchor.LastActiveAt,
                _ => null,
            };
        }
    }
}