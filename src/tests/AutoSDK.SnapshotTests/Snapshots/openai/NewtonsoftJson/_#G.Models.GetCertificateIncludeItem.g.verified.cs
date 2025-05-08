//HintName: G.Models.GetCertificateIncludeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetCertificateIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content")]
        Content,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCertificateIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCertificateIncludeItem value)
        {
            return value switch
            {
                GetCertificateIncludeItem.Content => "content",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCertificateIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "content" => GetCertificateIncludeItem.Content,
                _ => null,
            };
        }
    }
}