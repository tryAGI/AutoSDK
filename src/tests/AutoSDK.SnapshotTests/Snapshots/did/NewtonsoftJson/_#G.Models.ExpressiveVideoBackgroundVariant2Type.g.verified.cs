//HintName: G.Models.ExpressiveVideoBackgroundVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExpressiveVideoBackgroundVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_url")]
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExpressiveVideoBackgroundVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpressiveVideoBackgroundVariant2Type value)
        {
            return value switch
            {
                ExpressiveVideoBackgroundVariant2Type.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpressiveVideoBackgroundVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => ExpressiveVideoBackgroundVariant2Type.ImageUrl,
                _ => null,
            };
        }
    }
}