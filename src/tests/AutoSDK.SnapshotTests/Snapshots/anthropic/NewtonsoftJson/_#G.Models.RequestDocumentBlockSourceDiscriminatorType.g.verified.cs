//HintName: G.Models.RequestDocumentBlockSourceDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RequestDocumentBlockSourceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="base64")]
        Base64,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content")]
        Content,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="url")]
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestDocumentBlockSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestDocumentBlockSourceDiscriminatorType value)
        {
            return value switch
            {
                RequestDocumentBlockSourceDiscriminatorType.Base64 => "base64",
                RequestDocumentBlockSourceDiscriminatorType.Content => "content",
                RequestDocumentBlockSourceDiscriminatorType.Text => "text",
                RequestDocumentBlockSourceDiscriminatorType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestDocumentBlockSourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => RequestDocumentBlockSourceDiscriminatorType.Base64,
                "content" => RequestDocumentBlockSourceDiscriminatorType.Content,
                "text" => RequestDocumentBlockSourceDiscriminatorType.Text,
                "url" => RequestDocumentBlockSourceDiscriminatorType.Url,
                _ => null,
            };
        }
    }
}