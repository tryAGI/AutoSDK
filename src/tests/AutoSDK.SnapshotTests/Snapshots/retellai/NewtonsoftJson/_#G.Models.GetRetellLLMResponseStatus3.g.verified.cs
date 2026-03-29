//HintName: G.Models.GetRetellLLMResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetRetellLLMResponseStatus3
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
    public static class GetRetellLLMResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRetellLLMResponseStatus3 value)
        {
            return value switch
            {
                GetRetellLLMResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRetellLLMResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetRetellLLMResponseStatus3.Error,
                _ => null,
            };
        }
    }
}