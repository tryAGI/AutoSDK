//HintName: G.Models.UuidIndexType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UuidIndexType
    {
        /// <summary>
        /// 
        /// </summary>
        Uuid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UuidIndexTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UuidIndexType value)
        {
            return value switch
            {
                UuidIndexType.Uuid => "uuid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UuidIndexType? ToEnum(string value)
        {
            return value switch
            {
                "uuid" => UuidIndexType.Uuid,
                _ => null,
            };
        }
    }
}