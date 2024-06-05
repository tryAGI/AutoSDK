//HintName: JsonConverters.UpdateExtensionBitsProductBodyCostType.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateExtensionBitsProductBodyCostTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.UpdateExtensionBitsProductBodyCostType>
    {
        /// <inheritdoc />
        public override global::G.UpdateExtensionBitsProductBodyCostType Read(
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
                        return global::G.UpdateExtensionBitsProductBodyCostTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.UpdateExtensionBitsProductBodyCostType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.UpdateExtensionBitsProductBodyCostType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.UpdateExtensionBitsProductBodyCostTypeExtensions.ToValueString(value));
        }
    }
}
