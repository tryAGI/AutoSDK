//HintName: G.JsonConverters.ManagerConfigVariant1.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ManagerConfigVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ManagerConfigVariant1>
    {
        /// <inheritdoc />
        public override global::G.ManagerConfigVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GroupUpdateManagerConfigVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GroupUpdateManagerConfigVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GroupUpdateManagerConfigVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.RoundRobinManagerUpdate? roundRobin = default;
            if (discriminator?.ManagerType == global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerType.RoundRobin)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RoundRobinManagerUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RoundRobinManagerUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RoundRobinManagerUpdate)}");
                roundRobin = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SupervisorManagerUpdate? supervisor = default;
            if (discriminator?.ManagerType == global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerType.Supervisor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SupervisorManagerUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SupervisorManagerUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SupervisorManagerUpdate)}");
                supervisor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.DynamicManagerUpdate? dynamic = default;
            if (discriminator?.ManagerType == global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerType.Dynamic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DynamicManagerUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DynamicManagerUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DynamicManagerUpdate)}");
                dynamic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SleeptimeManagerUpdate? sleeptime = default;
            if (discriminator?.ManagerType == global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerType.Sleeptime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SleeptimeManagerUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SleeptimeManagerUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SleeptimeManagerUpdate)}");
                sleeptime = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.VoiceSleeptimeManagerUpdate? voiceSleeptime = default;
            if (discriminator?.ManagerType == global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerType.VoiceSleeptime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VoiceSleeptimeManagerUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VoiceSleeptimeManagerUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.VoiceSleeptimeManagerUpdate)}");
                voiceSleeptime = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ManagerConfigVariant1(
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
            global::G.ManagerConfigVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRoundRobin)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RoundRobinManagerUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RoundRobinManagerUpdate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RoundRobinManagerUpdate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RoundRobin, typeInfo);
            }
            else if (value.IsSupervisor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SupervisorManagerUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SupervisorManagerUpdate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SupervisorManagerUpdate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Supervisor, typeInfo);
            }
            else if (value.IsDynamic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DynamicManagerUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DynamicManagerUpdate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DynamicManagerUpdate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dynamic, typeInfo);
            }
            else if (value.IsSleeptime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SleeptimeManagerUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SleeptimeManagerUpdate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SleeptimeManagerUpdate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sleeptime, typeInfo);
            }
            else if (value.IsVoiceSleeptime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VoiceSleeptimeManagerUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VoiceSleeptimeManagerUpdate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.VoiceSleeptimeManagerUpdate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoiceSleeptime, typeInfo);
            }
        }
    }
}