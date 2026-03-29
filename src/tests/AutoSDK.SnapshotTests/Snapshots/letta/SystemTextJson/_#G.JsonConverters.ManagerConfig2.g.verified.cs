//HintName: G.JsonConverters.ManagerConfig2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ManagerConfig2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ManagerConfig2>
    {
        /// <inheritdoc />
        public override global::G.ManagerConfig2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GroupSchemaManagerConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GroupSchemaManagerConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GroupSchemaManagerConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.RoundRobinManager? roundRobin = default;
            if (discriminator?.ManagerType == global::G.GroupSchemaManagerConfigDiscriminatorManagerType.RoundRobin)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RoundRobinManager), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RoundRobinManager> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RoundRobinManager)}");
                roundRobin = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SupervisorManagerSchema? supervisor = default;
            if (discriminator?.ManagerType == global::G.GroupSchemaManagerConfigDiscriminatorManagerType.Supervisor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SupervisorManagerSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SupervisorManagerSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SupervisorManagerSchema)}");
                supervisor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.DynamicManagerSchema? dynamic = default;
            if (discriminator?.ManagerType == global::G.GroupSchemaManagerConfigDiscriminatorManagerType.Dynamic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DynamicManagerSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DynamicManagerSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DynamicManagerSchema)}");
                dynamic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SleeptimeManagerSchema? sleeptime = default;
            if (discriminator?.ManagerType == global::G.GroupSchemaManagerConfigDiscriminatorManagerType.Sleeptime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SleeptimeManagerSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SleeptimeManagerSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SleeptimeManagerSchema)}");
                sleeptime = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.VoiceSleeptimeManagerSchema? voiceSleeptime = default;
            if (discriminator?.ManagerType == global::G.GroupSchemaManagerConfigDiscriminatorManagerType.VoiceSleeptime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VoiceSleeptimeManagerSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VoiceSleeptimeManagerSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.VoiceSleeptimeManagerSchema)}");
                voiceSleeptime = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ManagerConfig2(
                discriminator?.ManagerType,
                roundRobin,

                supervisor,

                dynamic,

                sleeptime,

                voiceSleeptime
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ManagerConfig2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRoundRobin)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RoundRobinManager), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RoundRobinManager?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RoundRobinManager).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RoundRobin, typeInfo);
            }
            else if (value.IsSupervisor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SupervisorManagerSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SupervisorManagerSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SupervisorManagerSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Supervisor, typeInfo);
            }
            else if (value.IsDynamic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DynamicManagerSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DynamicManagerSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DynamicManagerSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dynamic, typeInfo);
            }
            else if (value.IsSleeptime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SleeptimeManagerSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SleeptimeManagerSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SleeptimeManagerSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sleeptime, typeInfo);
            }
            else if (value.IsVoiceSleeptime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VoiceSleeptimeManagerSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VoiceSleeptimeManagerSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.VoiceSleeptimeManagerSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoiceSleeptime, typeInfo);
            }
        }
    }
}