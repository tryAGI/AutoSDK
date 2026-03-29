//HintName: G.Models.ResponseEngineRetellLmType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// type of the Response Engine.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseEngineRetellLmType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="retell-llm")]
        RetellLlm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseEngineRetellLmTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseEngineRetellLmType value)
        {
            return value switch
            {
                ResponseEngineRetellLmType.RetellLlm => "retell-llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseEngineRetellLmType? ToEnum(string value)
        {
            return value switch
            {
                "retell-llm" => ResponseEngineRetellLmType.RetellLlm,
                _ => null,
            };
        }
    }
}