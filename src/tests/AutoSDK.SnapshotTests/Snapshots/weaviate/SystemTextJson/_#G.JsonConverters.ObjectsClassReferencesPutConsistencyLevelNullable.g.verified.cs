//HintName: G.JsonConverters.ObjectsClassReferencesPutConsistencyLevelNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ObjectsClassReferencesPutConsistencyLevelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ObjectsClassReferencesPutConsistencyLevel?>
    {
        /// <inheritdoc />
        public override global::G.ObjectsClassReferencesPutConsistencyLevel? Read(
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
                        return global::G.ObjectsClassReferencesPutConsistencyLevelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ObjectsClassReferencesPutConsistencyLevel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ObjectsClassReferencesPutConsistencyLevel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ObjectsClassReferencesPutConsistencyLevel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ObjectsClassReferencesPutConsistencyLevelExtensions.ToValueString(value.Value));
            }
        }
    }
}
