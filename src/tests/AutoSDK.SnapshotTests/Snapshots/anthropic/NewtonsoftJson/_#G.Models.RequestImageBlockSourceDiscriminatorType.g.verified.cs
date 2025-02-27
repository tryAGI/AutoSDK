//HintName: G.Models.RequestImageBlockSourceDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RequestImageBlockSourceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="base64")]
        Base64,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="url")]
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestImageBlockSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestImageBlockSourceDiscriminatorType value)
        {
            return value switch
            {
                RequestImageBlockSourceDiscriminatorType.Base64 => "base64",
                RequestImageBlockSourceDiscriminatorType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestImageBlockSourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => RequestImageBlockSourceDiscriminatorType.Base64,
                "url" => RequestImageBlockSourceDiscriminatorType.Url,
                _ => null,
            };
        }
    }
}