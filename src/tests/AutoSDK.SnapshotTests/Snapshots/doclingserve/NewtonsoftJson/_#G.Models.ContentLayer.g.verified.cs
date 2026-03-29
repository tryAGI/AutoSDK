//HintName: G.Models.ContentLayer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ContentLayer.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ContentLayer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="background")]
        Background,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="body")]
        Body,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="furniture")]
        Furniture,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invisible")]
        Invisible,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="notes")]
        Notes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentLayerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentLayer value)
        {
            return value switch
            {
                ContentLayer.Background => "background",
                ContentLayer.Body => "body",
                ContentLayer.Furniture => "furniture",
                ContentLayer.Invisible => "invisible",
                ContentLayer.Notes => "notes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentLayer? ToEnum(string value)
        {
            return value switch
            {
                "background" => ContentLayer.Background,
                "body" => ContentLayer.Body,
                "furniture" => ContentLayer.Furniture,
                "invisible" => ContentLayer.Invisible,
                "notes" => ContentLayer.Notes,
                _ => null,
            };
        }
    }
}