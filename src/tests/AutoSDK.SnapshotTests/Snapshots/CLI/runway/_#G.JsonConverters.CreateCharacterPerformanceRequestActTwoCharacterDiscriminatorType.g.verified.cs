//HintName: G.JsonConverters.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType Read(
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
                        return global::G.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
