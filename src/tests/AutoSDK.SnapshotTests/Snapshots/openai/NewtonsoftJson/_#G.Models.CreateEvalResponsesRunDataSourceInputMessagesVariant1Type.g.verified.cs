//HintName: G.Models.CreateEvalResponsesRunDataSourceInputMessagesVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of input messages. Always `template`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateEvalResponsesRunDataSourceInputMessagesVariant1Type
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
    public static class CreateEvalResponsesRunDataSourceInputMessagesVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEvalResponsesRunDataSourceInputMessagesVariant1Type value)
        {
            return value switch
            {
                CreateEvalResponsesRunDataSourceInputMessagesVariant1Type.Template => "template",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEvalResponsesRunDataSourceInputMessagesVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "template" => CreateEvalResponsesRunDataSourceInputMessagesVariant1Type.Template,
                _ => null,
            };
        }
    }
}