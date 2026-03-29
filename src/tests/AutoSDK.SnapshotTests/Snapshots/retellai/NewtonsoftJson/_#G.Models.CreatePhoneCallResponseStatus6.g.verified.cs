//HintName: G.Models.CreatePhoneCallResponseStatus6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreatePhoneCallResponseStatus6
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatePhoneCallResponseStatus6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePhoneCallResponseStatus6 value)
        {
            return value switch
            {
                CreatePhoneCallResponseStatus6.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePhoneCallResponseStatus6? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreatePhoneCallResponseStatus6.Error,
                _ => null,
            };
        }
    }
}