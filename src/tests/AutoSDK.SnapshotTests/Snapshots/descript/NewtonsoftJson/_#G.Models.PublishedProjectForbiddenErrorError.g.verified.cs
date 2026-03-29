//HintName: G.Models.PublishedProjectForbiddenErrorError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error type identifier<br/>
    /// Example: forbidden
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PublishedProjectForbiddenErrorError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="forbidden")]
        Forbidden,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublishedProjectForbiddenErrorErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublishedProjectForbiddenErrorError value)
        {
            return value switch
            {
                PublishedProjectForbiddenErrorError.Forbidden => "forbidden",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublishedProjectForbiddenErrorError? ToEnum(string value)
        {
            return value switch
            {
                "forbidden" => PublishedProjectForbiddenErrorError.Forbidden,
                _ => null,
            };
        }
    }
}