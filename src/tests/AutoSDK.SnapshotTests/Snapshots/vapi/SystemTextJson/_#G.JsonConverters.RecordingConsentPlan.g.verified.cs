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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompliancePlanRecordingConsentPlanDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompliancePlanRecordingConsentPlanDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CompliancePlanRecordingConsentPlanDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.RecordingConsentPlanStayOnLine? stayOnLine = default;
            if (discriminator?.Type == global::G.CompliancePlanRecordingConsentPlanDiscriminatorType.StayOnLine)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RecordingConsentPlanStayOnLine), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RecordingConsentPlanStayOnLine> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RecordingConsentPlanStayOnLine)}");
                stayOnLine = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RecordingConsentPlanVerbal? verbal = default;
            if (discriminator?.Type == global::G.CompliancePlanRecordingConsentPlanDiscriminatorType.Verbal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RecordingConsentPlanVerbal), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RecordingConsentPlanVerbal> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RecordingConsentPlanVerbal)}");
                verbal = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStayOnLine)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RecordingConsentPlanStayOnLine), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RecordingConsentPlanStayOnLine?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RecordingConsentPlanStayOnLine).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StayOnLine!, typeInfo);
            }
            else if (value.IsVerbal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RecordingConsentPlanVerbal), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RecordingConsentPlanVerbal?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RecordingConsentPlanVerbal).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Verbal!, typeInfo);
            }
        }
    }
}