//HintName: G.Models.UpdateDocumentRouteResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDocumentRouteResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
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