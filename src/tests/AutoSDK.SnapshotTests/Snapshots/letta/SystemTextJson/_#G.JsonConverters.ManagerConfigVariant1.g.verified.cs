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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GroupUpdateManagerConfigVariant1Discriminator>(ref readerCopy, options);

            global::G.RoundRobinManagerUpdate? roundRobin = default;
            if (discriminator?.ManagerType == global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerType.RoundRobin)
            {
                roundRobin = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RoundRobinManagerUpdate>(ref reader, options);
            }
            global::G.SupervisorManagerUpdate? supervisor = default;
            if (discriminator?.ManagerType == global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerType.Supervisor)
            {
                supervisor = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SupervisorManagerUpdate>(ref reader, options);
            }
            global::G.DynamicManagerUpdate? dynamic = default;
            if (discriminator?.ManagerType == global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerType.Dynamic)
            {
                dynamic = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DynamicManagerUpdate>(ref reader, options);
            }
            global::G.SleeptimeManagerUpdate? sleeptime = default;
            if (discriminator?.ManagerType == global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerType.Sleeptime)
            {
                sleeptime = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SleeptimeManagerUpdate>(ref reader, options);
            }
            global::G.VoiceSleeptimeManagerUpdate? voiceSleeptime = default;
            if (discriminator?.ManagerType == global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerType.VoiceSleeptime)
            {
                voiceSleeptime = global::System.Text.Json.JsonSerializer.Deserialize<global::G.VoiceSleeptimeManagerUpdate>(ref reader, options);
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

            if (value.IsRoundRobin)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RoundRobin, typeof(global::G.RoundRobinManagerUpdate), options);
            }
            else if (value.IsSupervisor)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Supervisor, typeof(global::G.SupervisorManagerUpdate), options);
            }
            else if (value.IsDynamic)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dynamic, typeof(global::G.DynamicManagerUpdate), options);
            }
            else if (value.IsSleeptime)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sleeptime, typeof(global::G.SleeptimeManagerUpdate), options);
            }
            else if (value.IsVoiceSleeptime)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoiceSleeptime, typeof(global::G.VoiceSleeptimeManagerUpdate), options);
            }
        }
    }
}