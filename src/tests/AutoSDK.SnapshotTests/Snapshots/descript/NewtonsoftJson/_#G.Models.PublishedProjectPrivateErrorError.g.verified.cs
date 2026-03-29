//HintName: G.Models.PublishedProjectPrivateErrorError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error type identifier<br/>
    /// Example: unauthorized
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PublishedProjectPrivateErrorError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unauthorized")]
        Unauthorized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublishedProjectPrivateErrorErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublishedProjectPrivateErrorError value)
        {
            return value switch
            {
                PublishedProjectPrivateErrorError.Unauthorized => "unauthorized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublishedProjectPrivateErrorError? ToEnum(string value)
        {
            return value switch
            {
                "unauthorized" => PublishedProjectPrivateErrorError.Unauthorized,
                _ => null,
            };
        }
    }
}