//HintName: G.Models.ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorType value)
        {
            return value switch
            {
                ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorType.Image => "image",
                ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image" => ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorType.Image,
                "text" => ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}