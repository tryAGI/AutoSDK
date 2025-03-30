//HintName: JsonConverters.PostWorkspaceSecretResponseModelType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PostWorkspaceSecretResponseModelTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PostWorkspaceSecretResponseModelType>
    {
        /// <inheritdoc />
        public override global::G.PostWorkspaceSecretResponseModelType Read(
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
                        return global::G.PostWorkspaceSecretResponseModelTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PostWorkspaceSecretResponseModelType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PostWorkspaceSecretResponseModelType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.PostWorkspaceSecretResponseModelTypeExtensions.ToValueString(value));
        }
    }
}
