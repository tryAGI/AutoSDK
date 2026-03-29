//HintName: G.JsonConverters.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenerateAssetPublicGenerationsPostResponseDiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GenerateAssetPublicGenerationsPostResponseDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.GenerateAssetPublicGenerationsPostResponseDiscriminatorType Read(
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
                        return global::G.GenerateAssetPublicGenerationsPostResponseDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GenerateAssetPublicGenerationsPostResponseDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.GenerateAssetPublicGenerationsPostResponseDiscriminatorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GenerateAssetPublicGenerationsPostResponseDiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.GenerateAssetPublicGenerationsPostResponseDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
