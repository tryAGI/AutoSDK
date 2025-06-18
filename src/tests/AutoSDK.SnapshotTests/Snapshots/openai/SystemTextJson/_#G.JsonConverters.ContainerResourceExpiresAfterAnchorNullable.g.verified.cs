//HintName: G.JsonConverters.ContainerResourceExpiresAfterAnchorNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ContainerResourceExpiresAfterAnchorNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ContainerResourceExpiresAfterAnchor?>
    {
        /// <inheritdoc />
        public override global::G.ContainerResourceExpiresAfterAnchor? Read(
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
                        return global::G.ContainerResourceExpiresAfterAnchorExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ContainerResourceExpiresAfterAnchor)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ContainerResourceExpiresAfterAnchor?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ContainerResourceExpiresAfterAnchor? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ContainerResourceExpiresAfterAnchorExtensions.ToValueString(value.Value));
            }
        }
    }
}
