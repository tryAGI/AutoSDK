//HintName: G.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItemNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItemNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem?>
    {
        /// <inheritdoc />
        public override global::G.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem? Read(
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
                        return global::G.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItemExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItemExtensions.ToValueString(value.Value));
            }
        }
    }
}
