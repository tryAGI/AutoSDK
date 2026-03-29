//HintName: G.Models.CreateVideoRequestVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Public videos will be visible to anyone with a share URL.<br/>
    /// Private videos can only be downloaded via a time-limited download link. See Retrieve a video for details.<br/>
    /// Visibility can be changed also once the video is created via Update a video.<br/>
    /// Default Value: private
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateVideoRequestVisibility
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
    public static class CreateVideoRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoRequestVisibility value)
        {
            return value switch
            {
                CreateVideoRequestVisibility.Private => "private",
                CreateVideoRequestVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreateVideoRequestVisibility.Private,
                "public" => CreateVideoRequestVisibility.Public,
                _ => null,
            };
        }
    }
}