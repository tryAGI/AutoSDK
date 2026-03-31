//HintName: G.Models.Create3RequestBackgroundVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum Create3RequestBackgroundVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Create3RequestBackgroundVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Create3RequestBackgroundVariant2Type value)
        {
            return value switch
            {
                Create3RequestBackgroundVariant2Type.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Create3RequestBackgroundVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => Create3RequestBackgroundVariant2Type.ImageUrl,
                _ => null,
            };
        }
    }
}