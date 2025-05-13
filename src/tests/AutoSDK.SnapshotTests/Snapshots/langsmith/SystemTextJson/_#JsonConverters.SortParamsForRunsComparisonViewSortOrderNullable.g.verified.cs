//HintName: JsonConverters.SortParamsForRunsComparisonViewSortOrderNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class SortParamsForRunsComparisonViewSortOrderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.SortParamsForRunsComparisonViewSortOrder?>
    {
        /// <inheritdoc />
        public override global::G.SortParamsForRunsComparisonViewSortOrder? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::G.SortParamsForRunsComparisonViewSortOrderExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.SortParamsForRunsComparisonViewSortOrder)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.SortParamsForRunsComparisonViewSortOrder?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.SortParamsForRunsComparisonViewSortOrder? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.SortParamsForRunsComparisonViewSortOrderExtensions.ToValueString(value.Value));
            }
        }
    }
}
