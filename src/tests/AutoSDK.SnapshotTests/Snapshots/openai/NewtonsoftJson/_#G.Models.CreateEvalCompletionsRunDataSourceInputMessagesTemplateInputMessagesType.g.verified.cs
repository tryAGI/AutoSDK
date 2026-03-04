//HintName: G.Models.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessagesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of input messages. Always `template`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessagesType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="template")]
        Template,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessagesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessagesType value)
        {
            return value switch
            {
                CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessagesType.Template => "template",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessagesType? ToEnum(string value)
        {
            return value switch
            {
                "template" => CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessagesType.Template,
                _ => null,
            };
        }
    }
}