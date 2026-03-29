//HintName: G.Models.DubbedAssetCompleteVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Describes the visibility settings of the video.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DubbedAssetCompleteVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DubbedAssetCompleteVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DubbedAssetCompleteVisibility value)
        {
            return value switch
            {
                DubbedAssetCompleteVisibility.Private => "private",
                DubbedAssetCompleteVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DubbedAssetCompleteVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => DubbedAssetCompleteVisibility.Private,
                "public" => DubbedAssetCompleteVisibility.Public,
                _ => null,
            };
        }
    }
}