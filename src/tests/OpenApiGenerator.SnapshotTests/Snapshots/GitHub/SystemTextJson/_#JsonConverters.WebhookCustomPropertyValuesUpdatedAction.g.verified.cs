//HintName: JsonConverters.WebhookCustomPropertyValuesUpdatedAction.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookCustomPropertyValuesUpdatedActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookCustomPropertyValuesUpdatedAction>
    {
        /// <inheritdoc />
        public override global::G.WebhookCustomPropertyValuesUpdatedAction Read(
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
                        return global::G.WebhookCustomPropertyValuesUpdatedActionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookCustomPropertyValuesUpdatedAction)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookCustomPropertyValuesUpdatedAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.WebhookCustomPropertyValuesUpdatedActionExtensions.ToValueString(value));
        }
    }
}
