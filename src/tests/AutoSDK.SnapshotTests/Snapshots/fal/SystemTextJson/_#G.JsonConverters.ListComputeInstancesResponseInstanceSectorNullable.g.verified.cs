//HintName: G.JsonConverters.ListComputeInstancesResponseInstanceSectorNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListComputeInstancesResponseInstanceSectorNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ListComputeInstancesResponseInstanceSector?>
    {
        /// <inheritdoc />
        public override global::G.ListComputeInstancesResponseInstanceSector? Read(
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
                        return global::G.ListComputeInstancesResponseInstanceSectorExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ListComputeInstancesResponseInstanceSector)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ListComputeInstancesResponseInstanceSector?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ListComputeInstancesResponseInstanceSector? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ListComputeInstancesResponseInstanceSectorExtensions.ToValueString(value.Value));
            }
        }
    }
}
