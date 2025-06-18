//HintName: G.Models.CreateContainerBodyExpiresAfterAnchor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Time anchor for the expiration time. Currently only 'last_active_at' is supported.
    /// </summary>
    public enum CreateContainerBodyExpiresAfterAnchor
    {
        /// <summary>
        /// 
        /// </summary>
        LastActiveAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateContainerBodyExpiresAfterAnchorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateContainerBodyExpiresAfterAnchor value)
        {
            return value switch
            {
                CreateContainerBodyExpiresAfterAnchor.LastActiveAt => "last_active_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateContainerBodyExpiresAfterAnchor? ToEnum(string value)
        {
            return value switch
            {
                "last_active_at" => CreateContainerBodyExpiresAfterAnchor.LastActiveAt,
                _ => null,
            };
        }
    }
}