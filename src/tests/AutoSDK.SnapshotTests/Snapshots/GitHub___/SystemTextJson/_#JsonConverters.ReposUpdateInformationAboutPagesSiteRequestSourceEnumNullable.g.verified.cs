//HintName: JsonConverters.ReposUpdateInformationAboutPagesSiteRequestSourceEnumNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReposUpdateInformationAboutPagesSiteRequestSourceEnumNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnum?>
    {
        /// <inheritdoc />
        public override global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnum? Read(
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
                        return global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnumExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnum)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnum? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnumExtensions.ToValueString(value.Value));
            }
        }
    }
}
