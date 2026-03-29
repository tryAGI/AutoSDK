//HintName: G.JsonConverters.ProviderResourceControllerGetProviderResourcesPaginatedSortOrder.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ProviderResourceControllerGetProviderResourcesPaginatedSortOrderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ProviderResourceControllerGetProviderResourcesPaginatedSortOrder>
    {
        /// <inheritdoc />
        public override global::G.ProviderResourceControllerGetProviderResourcesPaginatedSortOrder Read(
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
                        return global::G.ProviderResourceControllerGetProviderResourcesPaginatedSortOrderExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ProviderResourceControllerGetProviderResourcesPaginatedSortOrder)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ProviderResourceControllerGetProviderResourcesPaginatedSortOrder);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ProviderResourceControllerGetProviderResourcesPaginatedSortOrder value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ProviderResourceControllerGetProviderResourcesPaginatedSortOrderExtensions.ToValueString(value));
        }
    }
}
