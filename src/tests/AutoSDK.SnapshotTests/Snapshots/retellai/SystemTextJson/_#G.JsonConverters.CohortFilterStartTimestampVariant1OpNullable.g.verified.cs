//HintName: G.JsonConverters.CohortFilterStartTimestampVariant1OpNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CohortFilterStartTimestampVariant1OpNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CohortFilterStartTimestampVariant1Op?>
    {
        /// <inheritdoc />
        public override global::G.CohortFilterStartTimestampVariant1Op? Read(
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
                        return global::G.CohortFilterStartTimestampVariant1OpExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CohortFilterStartTimestampVariant1Op)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CohortFilterStartTimestampVariant1Op?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CohortFilterStartTimestampVariant1Op? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.CohortFilterStartTimestampVariant1OpExtensions.ToValueString(value.Value));
            }
        }
    }
}
