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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GroupSchemaManagerConfigDiscriminator>(ref readerCopy, options);

            global::G.RoundRobinManager? roundRobin = default;
            if (discriminator?.ManagerType == global::G.GroupSchemaManagerConfigDiscriminatorManagerType.RoundRobin)
            {
                roundRobin = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RoundRobinManager>(ref reader, options);
            }
            global::G.SupervisorManagerSchema? supervisor = default;
            if (discriminator?.ManagerType == global::G.GroupSchemaManagerConfigDiscriminatorManagerType.Supervisor)
            {
                supervisor = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SupervisorManagerSchema>(ref reader, options);
            }
            global::G.DynamicManagerSchema? dynamic = default;
            if (discriminator?.ManagerType == global::G.GroupSchemaManagerConfigDiscriminatorManagerType.Dynamic)
            {
                dynamic = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DynamicManagerSchema>(ref reader, options);
            }
            global::G.SleeptimeManagerSchema? sleeptime = default;
            if (discriminator?.ManagerType == global::G.GroupSchemaManagerConfigDiscriminatorManagerType.Sleeptime)
            {
                sleeptime = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SleeptimeManagerSchema>(ref reader, options);
            }
            global::G.VoiceSleeptimeManagerSchema? voiceSleeptime = default;
            if (discriminator?.ManagerType == global::G.GroupSchemaManagerConfigDiscriminatorManagerType.VoiceSleeptime)
            {
                voiceSleeptime = global::System.Text.Json.JsonSerializer.Deserialize<global::G.VoiceSleeptimeManagerSchema>(ref reader, options);
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

            if (value.IsRoundRobin)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RoundRobin, typeof(global::G.RoundRobinManager), options);
            }
            else if (value.IsSupervisor)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Supervisor, typeof(global::G.SupervisorManagerSchema), options);
            }
            else if (value.IsDynamic)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dynamic, typeof(global::G.DynamicManagerSchema), options);
            }
            else if (value.IsSleeptime)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sleeptime, typeof(global::G.SleeptimeManagerSchema), options);
            }
            else if (value.IsVoiceSleeptime)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoiceSleeptime, typeof(global::G.VoiceSleeptimeManagerSchema), options);
            }
        }
    }
}