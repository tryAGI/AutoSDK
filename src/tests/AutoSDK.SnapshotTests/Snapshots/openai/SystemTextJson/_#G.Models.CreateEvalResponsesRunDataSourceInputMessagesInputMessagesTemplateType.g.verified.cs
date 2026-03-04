//HintName: G.Models.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of input messages. Always `template`.
    /// </summary>
    public enum CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateType
    {
        /// <summary>
        /// 
        /// </summary>
        Template,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateType value)
        {
            return value switch
            {
                CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateType.Template => "template",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateType? ToEnum(string value)
        {
            return value switch
            {
                "template" => CreateEvalResponsesRunDataSourceInputMessagesInputMessagesTemplateType.Template,
                _ => null,
            };
        }
    }
}