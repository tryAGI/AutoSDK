//HintName: G.Models.CreateRequestLlmVariant5Model.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateRequestLlmVariant5Model
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
    public static class CreateRequestLlmVariant5ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRequestLlmVariant5Model value)
        {
            return value switch
            {
                CreateRequestLlmVariant5Model.GptOss120b => "gpt-oss-120b",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRequestLlmVariant5Model? ToEnum(string value)
        {
            return value switch
            {
                "gpt-oss-120b" => CreateRequestLlmVariant5Model.GptOss120b,
                _ => null,
            };
        }
    }
}