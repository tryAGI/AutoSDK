//HintName: G.Models.CreateEvalResponsesRunDataSourceInputMessagesInputMessagesItemReferenceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of input messages. Always `item_reference`.
    /// </summary>
    public enum CreateEvalResponsesRunDataSourceInputMessagesInputMessagesItemReferenceType
    {
        /// <summary>
        /// 
        /// </summary>
        ItemReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEvalResponsesRunDataSourceInputMessagesInputMessagesItemReferenceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEvalResponsesRunDataSourceInputMessagesInputMessagesItemReferenceType value)
        {
            return value switch
            {
                CreateEvalResponsesRunDataSourceInputMessagesInputMessagesItemReferenceType.ItemReference => "item_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEvalResponsesRunDataSourceInputMessagesInputMessagesItemReferenceType? ToEnum(string value)
        {
            return value switch
            {
                "item_reference" => CreateEvalResponsesRunDataSourceInputMessagesInputMessagesItemReferenceType.ItemReference,
                _ => null,
            };
        }
    }
}