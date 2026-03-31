//HintName: G.Models.CustomAuthConfigBasicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomAuthConfigBasicType
    {
        /// <summary>
        /// 
        /// </summary>
        Basic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomAuthConfigBasicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomAuthConfigBasicType value)
        {
            return value switch
            {
                CustomAuthConfigBasicType.Basic => "basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomAuthConfigBasicType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => CustomAuthConfigBasicType.Basic,
                _ => null,
            };
        }
    }
}