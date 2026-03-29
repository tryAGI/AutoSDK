//HintName: G.Models.SearchPostRequestBodyContentMultipartFormDataSchemaOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Combines multiple search options using `or` or `and`. Use `and` to find segments matching all search options. Use `or` to find segments matching any search option. For detailed guidance on using this parameter, see the [Combine multiple modalities](/v1.3/docs/concepts/modalities#combine-multiple-modalities) section.<br/>
    /// **Default**: `or`.<br/>
    /// Default Value: or
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SearchPostRequestBodyContentMultipartFormDataSchemaOperator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="and")]
        And,
        /// <summary>
        /// `or`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="or")]
        Or,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchPostRequestBodyContentMultipartFormDataSchemaOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchPostRequestBodyContentMultipartFormDataSchemaOperator value)
        {
            return value switch
            {
                SearchPostRequestBodyContentMultipartFormDataSchemaOperator.And => "and",
                SearchPostRequestBodyContentMultipartFormDataSchemaOperator.Or => "or",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchPostRequestBodyContentMultipartFormDataSchemaOperator? ToEnum(string value)
        {
            return value switch
            {
                "and" => SearchPostRequestBodyContentMultipartFormDataSchemaOperator.And,
                "or" => SearchPostRequestBodyContentMultipartFormDataSchemaOperator.Or,
                _ => null,
            };
        }
    }
}