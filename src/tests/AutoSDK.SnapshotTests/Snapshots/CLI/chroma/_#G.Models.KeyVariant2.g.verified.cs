//HintName: G.Models.KeyVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum KeyVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Embedding,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KeyVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KeyVariant2 value)
        {
            return value switch
            {
                KeyVariant2.Embedding => "Embedding",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KeyVariant2? ToEnum(string value)
        {
            return value switch
            {
                "Embedding" => KeyVariant2.Embedding,
                _ => null,
            };
        }
    }
}