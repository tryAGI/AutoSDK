//HintName: G.Models.CreateExpressiveRequestDtoBackgroundVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateExpressiveRequestDtoBackgroundVariant2Type
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
    public static class CreateExpressiveRequestDtoBackgroundVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateExpressiveRequestDtoBackgroundVariant2Type value)
        {
            return value switch
            {
                CreateExpressiveRequestDtoBackgroundVariant2Type.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateExpressiveRequestDtoBackgroundVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => CreateExpressiveRequestDtoBackgroundVariant2Type.ImageUrl,
                _ => null,
            };
        }
    }
}