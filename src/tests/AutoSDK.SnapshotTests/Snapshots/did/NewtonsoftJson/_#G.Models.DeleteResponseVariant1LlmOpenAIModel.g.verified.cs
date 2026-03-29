//HintName: G.Models.DeleteResponseVariant1LlmOpenAIModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteResponseVariant1LlmOpenAIModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1")]
        Gpt41,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-mini")]
        Gpt41Mini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-nano")]
        Gpt41Nano,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-global")]
        Gpt4oGlobal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-mini")]
        Gpt4oMini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5-mini")]
        Gpt5Mini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5-nano")]
        Gpt5Nano,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteResponseVariant1LlmOpenAIModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteResponseVariant1LlmOpenAIModel value)
        {
            return value switch
            {
                DeleteResponseVariant1LlmOpenAIModel.Gpt41 => "gpt-4.1",
                DeleteResponseVariant1LlmOpenAIModel.Gpt41Mini => "gpt-4.1-mini",
                DeleteResponseVariant1LlmOpenAIModel.Gpt41Nano => "gpt-4.1-nano",
                DeleteResponseVariant1LlmOpenAIModel.Gpt4oGlobal => "gpt-4o-global",
                DeleteResponseVariant1LlmOpenAIModel.Gpt4oMini => "gpt-4o-mini",
                DeleteResponseVariant1LlmOpenAIModel.Gpt5Mini => "gpt-5-mini",
                DeleteResponseVariant1LlmOpenAIModel.Gpt5Nano => "gpt-5-nano",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteResponseVariant1LlmOpenAIModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4.1" => DeleteResponseVariant1LlmOpenAIModel.Gpt41,
                "gpt-4.1-mini" => DeleteResponseVariant1LlmOpenAIModel.Gpt41Mini,
                "gpt-4.1-nano" => DeleteResponseVariant1LlmOpenAIModel.Gpt41Nano,
                "gpt-4o-global" => DeleteResponseVariant1LlmOpenAIModel.Gpt4oGlobal,
                "gpt-4o-mini" => DeleteResponseVariant1LlmOpenAIModel.Gpt4oMini,
                "gpt-5-mini" => DeleteResponseVariant1LlmOpenAIModel.Gpt5Mini,
                "gpt-5-nano" => DeleteResponseVariant1LlmOpenAIModel.Gpt5Nano,
                _ => null,
            };
        }
    }
}