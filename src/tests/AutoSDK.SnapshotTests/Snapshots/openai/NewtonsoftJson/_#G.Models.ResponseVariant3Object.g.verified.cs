//HintName: G.Models.ResponseVariant3Object.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type of this resource - always set to `response`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseVariant3Object
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response")]
        Response,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseVariant3ObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant3Object value)
        {
            return value switch
            {
                ResponseVariant3Object.Response => "response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant3Object? ToEnum(string value)
        {
            return value switch
            {
                "response" => ResponseVariant3Object.Response,
                _ => null,
            };
        }
    }
}