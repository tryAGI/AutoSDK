//HintName: G.JsonConverters.EventsItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class EventsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EventsItem>
    {
        /// <inheritdoc />
        public override global::G.EventsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MetadataSendTelemetryRequestEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MetadataSendTelemetryRequestEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MetadataSendTelemetryRequestEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.MetadataSendTelemetryRequestEventVariant1? sessionStart = default;
            if (discriminator?.Type == "session_start")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MetadataSendTelemetryRequestEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MetadataSendTelemetryRequestEventVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MetadataSendTelemetryRequestEventVariant1)}");
                sessionStart = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MetadataSendTelemetryRequestEventVariant2? sessionEnd = default;
            if (discriminator?.Type == "session_end")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MetadataSendTelemetryRequestEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MetadataSendTelemetryRequestEventVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MetadataSendTelemetryRequestEventVariant2)}");
                sessionEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MetadataSendTelemetryRequestEventVariant3? toolUsage = default;
            if (discriminator?.Type == "tool_usage")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MetadataSendTelemetryRequestEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MetadataSendTelemetryRequestEventVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MetadataSendTelemetryRequestEventVariant3)}");
                toolUsage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MetadataSendTelemetryRequestEventVariant4? error = default;
            if (discriminator?.Type == "error")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MetadataSendTelemetryRequestEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MetadataSendTelemetryRequestEventVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MetadataSendTelemetryRequestEventVariant4)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MetadataSendTelemetryRequestEventVariant5? userInput = default;
            if (discriminator?.Type == "user_input")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MetadataSendTelemetryRequestEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MetadataSendTelemetryRequestEventVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MetadataSendTelemetryRequestEventVariant5)}");
                userInput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.EventsItem(
                discriminator?.Type,
                sessionStart,

                sessionEnd,

                toolUsage,

                error,

                userInput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EventsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSessionStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MetadataSendTelemetryRequestEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MetadataSendTelemetryRequestEventVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MetadataSendTelemetryRequestEventVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionStart!, typeInfo);
            }
            else if (value.IsSessionEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MetadataSendTelemetryRequestEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MetadataSendTelemetryRequestEventVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MetadataSendTelemetryRequestEventVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionEnd!, typeInfo);
            }
            else if (value.IsToolUsage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MetadataSendTelemetryRequestEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MetadataSendTelemetryRequestEventVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MetadataSendTelemetryRequestEventVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolUsage!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MetadataSendTelemetryRequestEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MetadataSendTelemetryRequestEventVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MetadataSendTelemetryRequestEventVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
            else if (value.IsUserInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MetadataSendTelemetryRequestEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MetadataSendTelemetryRequestEventVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MetadataSendTelemetryRequestEventVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserInput!, typeInfo);
            }
        }
    }
}