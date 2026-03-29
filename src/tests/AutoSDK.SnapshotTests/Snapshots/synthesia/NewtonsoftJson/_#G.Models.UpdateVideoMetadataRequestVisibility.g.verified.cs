//HintName: G.Models.UpdateVideoMetadataRequestVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateVideoMetadataRequestVisibility
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
    public static class UpdateVideoMetadataRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateVideoMetadataRequestVisibility value)
        {
            return value switch
            {
                UpdateVideoMetadataRequestVisibility.Private => "private",
                UpdateVideoMetadataRequestVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateVideoMetadataRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => UpdateVideoMetadataRequestVisibility.Private,
                "public" => UpdateVideoMetadataRequestVisibility.Public,
                _ => null,
            };
        }
    }
}