//HintName: G.Models.CreateResponseRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateResponseRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemma2-9b-it")]
        Gemma29bIt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llama-3.1-8b-instant")]
        Llama318bInstant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llama-3.3-70b-versatile")]
        Llama3370bVersatile,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llama-guard-3-8b")]
        LlamaGuard38b,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llama3-70b-8192")]
        Llama370b8192,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llama3-8b-8192")]
        Llama38b8192,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateResponseRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseRequestModel value)
        {
            return value switch
            {
                CreateResponseRequestModel.Gemma29bIt => "gemma2-9b-it",
                CreateResponseRequestModel.Llama318bInstant => "llama-3.1-8b-instant",
                CreateResponseRequestModel.Llama3370bVersatile => "llama-3.3-70b-versatile",
                CreateResponseRequestModel.LlamaGuard38b => "llama-guard-3-8b",
                CreateResponseRequestModel.Llama370b8192 => "llama3-70b-8192",
                CreateResponseRequestModel.Llama38b8192 => "llama3-8b-8192",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "gemma2-9b-it" => CreateResponseRequestModel.Gemma29bIt,
                "llama-3.1-8b-instant" => CreateResponseRequestModel.Llama318bInstant,
                "llama-3.3-70b-versatile" => CreateResponseRequestModel.Llama3370bVersatile,
                "llama-guard-3-8b" => CreateResponseRequestModel.LlamaGuard38b,
                "llama3-70b-8192" => CreateResponseRequestModel.Llama370b8192,
                "llama3-8b-8192" => CreateResponseRequestModel.Llama38b8192,
                _ => null,
            };
        }
    }
}