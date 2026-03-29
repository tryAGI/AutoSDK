//HintName: G.Models.CreateKeysSubType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateKeysSubType
    {
        /// <summary>
        /// 
        /// </summary>
        Service,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateKeysSubTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateKeysSubType value)
        {
            return value switch
            {
                CreateKeysSubType.Service => "service",
                CreateKeysSubType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateKeysSubType? ToEnum(string value)
        {
            return value switch
            {
                "service" => CreateKeysSubType.Service,
                "user" => CreateKeysSubType.User,
                _ => null,
            };
        }
    }
}