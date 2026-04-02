//HintName: G.JsonConverters.ManagerConfig.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ManagerConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ManagerConfig>
    {
        /// <inheritdoc />
        public override global::G.ManagerConfig Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GroupCreateManagerConfigDiscriminator>(ref readerCopy, options);

            global::G.RoundRobinManager? roundRobin = default;
            if (discriminator?.ManagerType == global::G.GroupCreateManagerConfigDiscriminatorManagerType.RoundRobin)
            {
                roundRobin = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RoundRobinManager>(ref reader, options);
            }
            global::G.SupervisorManager? supervisor = default;
            if (discriminator?.ManagerType == global::G.GroupCreateManagerConfigDiscriminatorManagerType.Supervisor)
            {
                supervisor = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SupervisorManager>(ref reader, options);
            }
            global::G.DynamicManager? dynamic = default;
            if (discriminator?.ManagerType == global::G.GroupCreateManagerConfigDiscriminatorManagerType.Dynamic)
            {
                dynamic = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DynamicManager>(ref reader, options);
            }
            global::G.SleeptimeManager? sleeptime = default;
            if (discriminator?.ManagerType == global::G.GroupCreateManagerConfigDiscriminatorManagerType.Sleeptime)
            {
                sleeptime = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SleeptimeManager>(ref reader, options);
            }
            global::G.VoiceSleeptimeManager? voiceSleeptime = default;
            if (discriminator?.ManagerType == global::G.GroupCreateManagerConfigDiscriminatorManagerType.VoiceSleeptime)
            {
                voiceSleeptime = global::System.Text.Json.JsonSerializer.Deserialize<global::G.VoiceSleeptimeManager>(ref reader, options);
            }

            var __value = new global::G.ManagerConfig(
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
            global::G.ManagerConfig value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsRoundRobin)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RoundRobin, typeof(global::G.RoundRobinManager), options);
            }
            else if (value.IsSupervisor)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Supervisor, typeof(global::G.SupervisorManager), options);
            }
            else if (value.IsDynamic)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dynamic, typeof(global::G.DynamicManager), options);
            }
            else if (value.IsSleeptime)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sleeptime, typeof(global::G.SleeptimeManager), options);
            }
            else if (value.IsVoiceSleeptime)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoiceSleeptime, typeof(global::G.VoiceSleeptimeManager), options);
            }
        }
    }
}