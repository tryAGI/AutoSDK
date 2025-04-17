//HintName: JsonConverters.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType>
    {
        /// <inheritdoc />
        public override global::G.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType Read(
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
                        return global::G.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobTypeExtensions.ToValueString(value));
        }
    }
}
