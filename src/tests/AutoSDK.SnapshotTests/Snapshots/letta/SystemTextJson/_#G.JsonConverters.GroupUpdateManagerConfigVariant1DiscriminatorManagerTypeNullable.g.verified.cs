//HintName: G.JsonConverters.GroupUpdateManagerConfigVariant1DiscriminatorManagerTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GroupUpdateManagerConfigVariant1DiscriminatorManagerTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerType?>
    {
        /// <inheritdoc />
        public override global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerType? Read(
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
                        return global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
