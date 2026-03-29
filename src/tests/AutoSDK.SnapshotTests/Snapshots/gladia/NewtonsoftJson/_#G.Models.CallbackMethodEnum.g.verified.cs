//HintName: G.Models.CallbackMethodEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The HTTP method to be used. Allowed values are `POST` or `PUT` (default: `POST`)
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CallbackMethodEnum
    {
        /// <summary>
        /// `POST`)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="POST")]
        Post,
        /// <summary>
        /// `POST`)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PUT")]
        Put,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallbackMethodEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallbackMethodEnum value)
        {
            return value switch
            {
                CallbackMethodEnum.Post => "POST",
                CallbackMethodEnum.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallbackMethodEnum? ToEnum(string value)
        {
            return value switch
            {
                "POST" => CallbackMethodEnum.Post,
                "PUT" => CallbackMethodEnum.Put,
                _ => null,
            };
        }
    }
}