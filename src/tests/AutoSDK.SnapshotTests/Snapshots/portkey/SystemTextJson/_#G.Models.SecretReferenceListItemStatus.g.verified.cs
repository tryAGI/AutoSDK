//HintName: G.Models.SecretReferenceListItemStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SecretReferenceListItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretReferenceListItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretReferenceListItemStatus value)
        {
            return value switch
            {
                SecretReferenceListItemStatus.Active => "ACTIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretReferenceListItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => SecretReferenceListItemStatus.Active,
                _ => null,
            };
        }
    }
}