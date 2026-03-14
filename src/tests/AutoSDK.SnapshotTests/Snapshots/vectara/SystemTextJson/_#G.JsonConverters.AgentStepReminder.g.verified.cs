//HintName: G.JsonConverters.AgentStepReminder.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AgentStepReminderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AgentStepReminder>
    {
        /// <inheritdoc />
        public override global::G.AgentStepReminder Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentStepReminderDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentStepReminderDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AgentStepReminderDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.TemplatedReminder? templated = default;
            if (discriminator?.Type == global::G.AgentStepReminderDiscriminatorType.Templated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TemplatedReminder), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TemplatedReminder> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TemplatedReminder)}");
                templated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.AgentStepReminder(
                discriminator?.Type,
                templated
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AgentStepReminder value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTemplated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TemplatedReminder), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TemplatedReminder?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TemplatedReminder).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Templated, typeInfo);
            }
        }
    }
}