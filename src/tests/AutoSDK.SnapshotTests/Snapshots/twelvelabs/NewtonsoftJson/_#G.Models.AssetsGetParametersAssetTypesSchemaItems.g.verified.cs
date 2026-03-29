//HintName: G.Models.AssetsGetParametersAssetTypesSchemaItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssetsGetParametersAssetTypesSchemaItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio")]
        Audio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video")]
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetsGetParametersAssetTypesSchemaItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetsGetParametersAssetTypesSchemaItems value)
        {
            return value switch
            {
                AssetsGetParametersAssetTypesSchemaItems.Audio => "audio",
                AssetsGetParametersAssetTypesSchemaItems.Image => "image",
                AssetsGetParametersAssetTypesSchemaItems.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetsGetParametersAssetTypesSchemaItems? ToEnum(string value)
        {
            return value switch
            {
                "audio" => AssetsGetParametersAssetTypesSchemaItems.Audio,
                "image" => AssetsGetParametersAssetTypesSchemaItems.Image,
                "video" => AssetsGetParametersAssetTypesSchemaItems.Video,
                _ => null,
            };
        }
    }
}