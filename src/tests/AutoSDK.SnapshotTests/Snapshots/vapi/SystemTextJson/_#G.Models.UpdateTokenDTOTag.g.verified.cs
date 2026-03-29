//HintName: G.Models.UpdateTokenDTOTag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the tag for the token. It represents its scope.
    /// </summary>
    public enum UpdateTokenDTOTag
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateTokenDTOTagExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateTokenDTOTag value)
        {
            return value switch
            {
                UpdateTokenDTOTag.Private => "private",
                UpdateTokenDTOTag.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateTokenDTOTag? ToEnum(string value)
        {
            return value switch
            {
                "private" => UpdateTokenDTOTag.Private,
                "public" => UpdateTokenDTOTag.Public,
                _ => null,
            };
        }
    }
}