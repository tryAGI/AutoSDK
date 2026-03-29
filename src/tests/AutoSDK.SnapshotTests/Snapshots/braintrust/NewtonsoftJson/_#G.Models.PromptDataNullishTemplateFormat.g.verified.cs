//HintName: G.Models.PromptDataNullishTemplateFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptDataNullishTemplateFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mustache")]
        Mustache,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nunjucks")]
        Nunjucks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptDataNullishTemplateFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptDataNullishTemplateFormat value)
        {
            return value switch
            {
                PromptDataNullishTemplateFormat.Mustache => "mustache",
                PromptDataNullishTemplateFormat.None => "none",
                PromptDataNullishTemplateFormat.Nunjucks => "nunjucks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptDataNullishTemplateFormat? ToEnum(string value)
        {
            return value switch
            {
                "mustache" => PromptDataNullishTemplateFormat.Mustache,
                "none" => PromptDataNullishTemplateFormat.None,
                "nunjucks" => PromptDataNullishTemplateFormat.Nunjucks,
                _ => null,
            };
        }
    }
}