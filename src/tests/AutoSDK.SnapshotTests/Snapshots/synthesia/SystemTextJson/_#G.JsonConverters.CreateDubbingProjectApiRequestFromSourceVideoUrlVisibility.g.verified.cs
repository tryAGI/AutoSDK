//HintName: G.JsonConverters.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibility.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateDubbingProjectApiRequestFromSourceVideoUrlVisibilityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibility>
    {
        /// <inheritdoc />
        public override global::G.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibility Read(
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
                        return global::G.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibilityExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibility)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibility);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibility value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibilityExtensions.ToValueString(value));
        }
    }
}
