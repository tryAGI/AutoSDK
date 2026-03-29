//HintName: G.JsonConverters.ManagerConfig3.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ManagerConfig3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ManagerConfig3>
    {
        /// <inheritdoc />
        public override global::G.ManagerConfig3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InternalTemplateGroupCreateManagerConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InternalTemplateGroupCreateManagerConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InternalTemplateGroupCreateManagerConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.RoundRobinManager? roundRobin = default;
            if (discriminator?.ManagerType == global::G.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType.RoundRobin)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RoundRobinManager), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RoundRobinManager> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RoundRobinManager)}");
                roundRobin = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SupervisorManager? supervisor = default;
            if (discriminator?.ManagerType == global::G.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType.Supervisor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SupervisorManager), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SupervisorManager> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SupervisorManager)}");
                supervisor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.DynamicManager? dynamic = default;
            if (discriminator?.ManagerType == global::G.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType.Dynamic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DynamicManager), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DynamicManager> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DynamicManager)}");
                dynamic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SleeptimeManager? sleeptime = default;
            if (discriminator?.ManagerType == global::G.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType.Sleeptime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SleeptimeManager), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SleeptimeManager> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SleeptimeManager)}");
                sleeptime = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.VoiceSleeptimeManager? voiceSleeptime = default;
            if (discriminator?.ManagerType == global::G.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType.VoiceSleeptime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VoiceSleeptimeManager), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VoiceSleeptimeManager> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.VoiceSleeptimeManager)}");
                voiceSleeptime = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ManagerConfig3(
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
            global::G.ManagerConfig3 value,
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
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SupervisorManager), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SupervisorManager?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SupervisorManager).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Supervisor, typeInfo);
            }
            else if (value.IsDynamic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DynamicManager), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DynamicManager?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DynamicManager).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dynamic, typeInfo);
            }
            else if (value.IsSleeptime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SleeptimeManager), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SleeptimeManager?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SleeptimeManager).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sleeptime, typeInfo);
            }
            else if (value.IsVoiceSleeptime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VoiceSleeptimeManager), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VoiceSleeptimeManager?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.VoiceSleeptimeManager).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoiceSleeptime, typeInfo);
            }
        }
    }
}