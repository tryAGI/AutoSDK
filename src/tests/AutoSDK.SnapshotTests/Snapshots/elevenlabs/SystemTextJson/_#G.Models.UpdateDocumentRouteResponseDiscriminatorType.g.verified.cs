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
        File,
        /// <summary>
        /// 
        /// </summary>
        Folder,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Url,
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
                UpdateDocumentRouteResponseDiscriminatorType.File => "file",
                UpdateDocumentRouteResponseDiscriminatorType.Folder => "folder",
                UpdateDocumentRouteResponseDiscriminatorType.Text => "text",
                UpdateDocumentRouteResponseDiscriminatorType.Url => "url",
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
                "file" => UpdateDocumentRouteResponseDiscriminatorType.File,
                "folder" => UpdateDocumentRouteResponseDiscriminatorType.Folder,
                "text" => UpdateDocumentRouteResponseDiscriminatorType.Text,
                "url" => UpdateDocumentRouteResponseDiscriminatorType.Url,
                _ => null,
            };
        }
    }
}