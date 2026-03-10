//HintName: G.Models.UpdateDocumentRouteResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateDocumentRouteResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="url")]
        Url,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file")]
        File,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="folder")]
        Folder,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDocumentRouteResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDocumentRouteResponseDiscriminatorType value)
        {
            return value switch
            {
                UpdateDocumentRouteResponseDiscriminatorType.Url => "url",
                UpdateDocumentRouteResponseDiscriminatorType.File => "file",
                UpdateDocumentRouteResponseDiscriminatorType.Text => "text",
                UpdateDocumentRouteResponseDiscriminatorType.Folder => "folder",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDocumentRouteResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "url" => UpdateDocumentRouteResponseDiscriminatorType.Url,
                "file" => UpdateDocumentRouteResponseDiscriminatorType.File,
                "text" => UpdateDocumentRouteResponseDiscriminatorType.Text,
                "folder" => UpdateDocumentRouteResponseDiscriminatorType.Folder,
                _ => null,
            };
        }
    }
}