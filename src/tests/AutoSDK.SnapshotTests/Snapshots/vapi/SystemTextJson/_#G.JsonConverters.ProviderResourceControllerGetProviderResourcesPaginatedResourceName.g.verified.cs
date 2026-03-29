//HintName: G.JsonConverters.ProviderResourceControllerGetProviderResourcesPaginatedResourceName.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ProviderResourceControllerGetProviderResourcesPaginatedResourceNameJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ProviderResourceControllerGetProviderResourcesPaginatedResourceName>
    {
        /// <inheritdoc />
        public override global::G.ProviderResourceControllerGetProviderResourcesPaginatedResourceName Read(
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
                        return global::G.ProviderResourceControllerGetProviderResourcesPaginatedResourceNameExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ProviderResourceControllerGetProviderResourcesPaginatedResourceName)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ProviderResourceControllerGetProviderResourcesPaginatedResourceName);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ProviderResourceControllerGetProviderResourcesPaginatedResourceName value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ProviderResourceControllerGetProviderResourcesPaginatedResourceNameExtensions.ToValueString(value));
        }
    }
}
