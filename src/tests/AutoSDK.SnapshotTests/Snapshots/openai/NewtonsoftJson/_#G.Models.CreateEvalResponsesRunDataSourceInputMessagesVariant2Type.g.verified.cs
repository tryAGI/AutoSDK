//HintName: G.Models.CreateEvalResponsesRunDataSourceInputMessagesVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of input messages. Always `item_reference`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateEvalResponsesRunDataSourceInputMessagesVariant2Type
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
    public static class CreateEvalResponsesRunDataSourceInputMessagesVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEvalResponsesRunDataSourceInputMessagesVariant2Type value)
        {
            return value switch
            {
                CreateEvalResponsesRunDataSourceInputMessagesVariant2Type.ItemReference => "item_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEvalResponsesRunDataSourceInputMessagesVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "item_reference" => CreateEvalResponsesRunDataSourceInputMessagesVariant2Type.ItemReference,
                _ => null,
            };
        }
    }
}