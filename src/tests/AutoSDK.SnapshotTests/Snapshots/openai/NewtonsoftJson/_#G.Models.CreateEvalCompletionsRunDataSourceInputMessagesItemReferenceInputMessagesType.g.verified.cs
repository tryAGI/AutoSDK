//HintName: G.Models.CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessagesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of input messages. Always `item_reference`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessagesType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="item_reference")]
        ItemReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessagesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessagesType value)
        {
            return value switch
            {
                CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessagesType.ItemReference => "item_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessagesType? ToEnum(string value)
        {
            return value switch
            {
                "item_reference" => CreateEvalCompletionsRunDataSourceInputMessagesItemReferenceInputMessagesType.ItemReference,
                _ => null,
            };
        }
    }
}