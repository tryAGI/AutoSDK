//HintName: G.JsonConverters.CartesiaExperimentalControlsSpeed.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CartesiaExperimentalControlsSpeedJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CartesiaExperimentalControlsSpeed>
    {
        /// <inheritdoc />
        public override global::G.CartesiaExperimentalControlsSpeed Read(
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
                        return global::G.CartesiaExperimentalControlsSpeedExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CartesiaExperimentalControlsSpeed)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CartesiaExperimentalControlsSpeed);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CartesiaExperimentalControlsSpeed value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.CartesiaExperimentalControlsSpeedExtensions.ToValueString(value));
        }
    }
}
