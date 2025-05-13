//HintName: JsonConverters.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType?>
    {
        /// <inheritdoc />
        public override global::G.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType? Read(
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
                        return global::G.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
