//HintName: G.Models.GistsCreateRequestPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: false<br/>
    /// Example: true
    /// </summary>
    public enum GistsCreateRequestPublic
    {
        /// <summary>
        /// 
        /// </summary>
        True,
        /// <summary>
        /// 
        /// </summary>
        False,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GistsCreateRequestPublicExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GistsCreateRequestPublic value)
        {
            return value switch
            {
                GistsCreateRequestPublic.True => "true",
                GistsCreateRequestPublic.False => "false",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GistsCreateRequestPublic? ToEnum(string value)
        {
            return value switch
            {
                "true" => GistsCreateRequestPublic.True,
                "false" => GistsCreateRequestPublic.False,
                _ => null,
            };
        }
    }
}