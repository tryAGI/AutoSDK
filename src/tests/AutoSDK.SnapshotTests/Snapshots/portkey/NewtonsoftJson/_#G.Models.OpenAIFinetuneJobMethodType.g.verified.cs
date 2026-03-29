//HintName: G.Models.OpenAIFinetuneJobMethodType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAIFinetuneJobMethodType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dpo")]
        Dpo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="supervised")]
        Supervised,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIFinetuneJobMethodTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIFinetuneJobMethodType value)
        {
            return value switch
            {
                OpenAIFinetuneJobMethodType.Dpo => "dpo",
                OpenAIFinetuneJobMethodType.Supervised => "supervised",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIFinetuneJobMethodType? ToEnum(string value)
        {
            return value switch
            {
                "dpo" => OpenAIFinetuneJobMethodType.Dpo,
                "supervised" => OpenAIFinetuneJobMethodType.Supervised,
                _ => null,
            };
        }
    }
}