//HintName: G.Models.CreateEvalCompletionsRunDataSourceInputMessagesVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of input messages. Always `item_reference`.
    /// </summary>
    public enum CreateEvalCompletionsRunDataSourceInputMessagesVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        ItemReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEvalCompletionsRunDataSourceInputMessagesVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEvalCompletionsRunDataSourceInputMessagesVariant2Type value)
        {
            return value switch
            {
                CreateEvalCompletionsRunDataSourceInputMessagesVariant2Type.ItemReference => "item_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEvalCompletionsRunDataSourceInputMessagesVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "item_reference" => CreateEvalCompletionsRunDataSourceInputMessagesVariant2Type.ItemReference,
                _ => null,
            };
        }
    }
}