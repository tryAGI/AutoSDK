//HintName: G.Models.CreateEvalCompletionsRunDataSourceInputMessagesVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of input messages. Always `template`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateEvalCompletionsRunDataSourceInputMessagesVariant1Type
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
    public static class CreateEvalCompletionsRunDataSourceInputMessagesVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEvalCompletionsRunDataSourceInputMessagesVariant1Type value)
        {
            return value switch
            {
                CreateEvalCompletionsRunDataSourceInputMessagesVariant1Type.Template => "template",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEvalCompletionsRunDataSourceInputMessagesVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "template" => CreateEvalCompletionsRunDataSourceInputMessagesVariant1Type.Template,
                _ => null,
            };
        }
    }
}