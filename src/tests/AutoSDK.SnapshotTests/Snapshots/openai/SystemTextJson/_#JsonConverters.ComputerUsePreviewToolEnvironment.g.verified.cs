//HintName: JsonConverters.ComputerUsePreviewToolEnvironment.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ComputerUsePreviewToolEnvironmentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ComputerUsePreviewToolEnvironment>
    {
        /// <inheritdoc />
        public override global::G.ComputerUsePreviewToolEnvironment Read(
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
                        return global::G.ComputerUsePreviewToolEnvironmentExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ComputerUsePreviewToolEnvironment)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ComputerUsePreviewToolEnvironment value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ComputerUsePreviewToolEnvironmentExtensions.ToValueString(value));
        }
    }
}
