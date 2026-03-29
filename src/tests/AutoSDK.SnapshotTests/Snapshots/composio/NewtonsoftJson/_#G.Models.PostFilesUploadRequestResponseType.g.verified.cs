//HintName: G.Models.PostFilesUploadRequestResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// [DEPRECATED] Indicates this is a new file that needs to be uploaded
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostFilesUploadRequestResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="new")]
        New,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostFilesUploadRequestResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostFilesUploadRequestResponseType value)
        {
            return value switch
            {
                PostFilesUploadRequestResponseType.New => "new",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostFilesUploadRequestResponseType? ToEnum(string value)
        {
            return value switch
            {
                "new" => PostFilesUploadRequestResponseType.New,
                _ => null,
            };
        }
    }
}