//HintName: G.JsonConverters.TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategyNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategyNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategy?>
    {
        /// <inheritdoc />
        public override global::G.TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategy? Read(
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
                        return global::G.TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategyExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategy?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategy? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategyExtensions.ToValueString(value.Value));
            }
        }
    }
}
