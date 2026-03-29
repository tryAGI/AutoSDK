//HintName: G.Models.DIdLLMCreateDtoModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DIdLLMCreateDtoModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-oss-120b")]
        GptOss120b,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DIdLLMCreateDtoModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DIdLLMCreateDtoModel value)
        {
            return value switch
            {
                DIdLLMCreateDtoModel.GptOss120b => "gpt-oss-120b",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DIdLLMCreateDtoModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-oss-120b" => DIdLLMCreateDtoModel.GptOss120b,
                _ => null,
            };
        }
    }
}