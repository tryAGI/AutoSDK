//HintName: G.Models.PublishedProjectErrorError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error type identifier<br/>
    /// Example: not_found
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PublishedProjectErrorError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="forbidden")]
        Forbidden,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_found")]
        NotFound,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unauthorized")]
        Unauthorized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublishedProjectErrorErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublishedProjectErrorError value)
        {
            return value switch
            {
                PublishedProjectErrorError.Forbidden => "forbidden",
                PublishedProjectErrorError.NotFound => "not_found",
                PublishedProjectErrorError.Unauthorized => "unauthorized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublishedProjectErrorError? ToEnum(string value)
        {
            return value switch
            {
                "forbidden" => PublishedProjectErrorError.Forbidden,
                "not_found" => PublishedProjectErrorError.NotFound,
                "unauthorized" => PublishedProjectErrorError.Unauthorized,
                _ => null,
            };
        }
    }
}