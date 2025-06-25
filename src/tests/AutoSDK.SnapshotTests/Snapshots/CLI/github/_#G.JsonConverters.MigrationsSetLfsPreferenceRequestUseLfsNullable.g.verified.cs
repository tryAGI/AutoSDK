//HintName: G.JsonConverters.MigrationsSetLfsPreferenceRequestUseLfsNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class MigrationsSetLfsPreferenceRequestUseLfsNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MigrationsSetLfsPreferenceRequestUseLfs?>
    {
        /// <inheritdoc />
        public override global::G.MigrationsSetLfsPreferenceRequestUseLfs? Read(
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
                        return global::G.MigrationsSetLfsPreferenceRequestUseLfsExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.MigrationsSetLfsPreferenceRequestUseLfs)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.MigrationsSetLfsPreferenceRequestUseLfs?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MigrationsSetLfsPreferenceRequestUseLfs? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.MigrationsSetLfsPreferenceRequestUseLfsExtensions.ToValueString(value.Value));
            }
        }
    }
}
