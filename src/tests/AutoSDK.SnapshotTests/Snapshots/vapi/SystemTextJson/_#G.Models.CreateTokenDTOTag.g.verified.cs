//HintName: G.Models.CreateTokenDTOTag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the tag for the token. It represents its scope.
    /// </summary>
    public enum CreateTokenDTOTag
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
    public static class CreateTokenDTOTagExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTokenDTOTag value)
        {
            return value switch
            {
                CreateTokenDTOTag.Private => "private",
                CreateTokenDTOTag.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTokenDTOTag? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreateTokenDTOTag.Private,
                "public" => CreateTokenDTOTag.Public,
                _ => null,
            };
        }
    }
}