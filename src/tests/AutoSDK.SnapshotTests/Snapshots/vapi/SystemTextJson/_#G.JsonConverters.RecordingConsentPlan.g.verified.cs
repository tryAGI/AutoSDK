//HintName: G.JsonConverters.RecordingConsentPlan.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class RecordingConsentPlanJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RecordingConsentPlan>
    {
        /// <inheritdoc />
        public override global::G.RecordingConsentPlan Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CompliancePlanRecordingConsentPlanDiscriminator>(ref readerCopy, options);

            global::G.RecordingConsentPlanStayOnLine? stayOnLine = default;
            if (discriminator?.Type == global::G.CompliancePlanRecordingConsentPlanDiscriminatorType.StayOnLine)
            {
                stayOnLine = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RecordingConsentPlanStayOnLine>(ref reader, options);
            }
            global::G.RecordingConsentPlanVerbal? verbal = default;
            if (discriminator?.Type == global::G.CompliancePlanRecordingConsentPlanDiscriminatorType.Verbal)
            {
                verbal = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RecordingConsentPlanVerbal>(ref reader, options);
            }

            var __value = new global::G.RecordingConsentPlan(
                discriminator?.Type,
                stayOnLine,

                verbal
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RecordingConsentPlan value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsStayOnLine)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StayOnLine, typeof(global::G.RecordingConsentPlanStayOnLine), options);
            }
            else if (value.IsVerbal)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Verbal, typeof(global::G.RecordingConsentPlanVerbal), options);
            }
        }
    }
}