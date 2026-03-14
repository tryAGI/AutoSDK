//HintName: G.JsonConverters.ScheduleConfiguration.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ScheduleConfigurationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ScheduleConfiguration>
    {
        /// <inheritdoc />
        public override global::G.ScheduleConfiguration Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.IntervalScheduleConfiguration? interval = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.IntervalScheduleConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.IntervalScheduleConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.IntervalScheduleConfiguration).Name}");
                interval = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.CronScheduleConfiguration? cron = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CronScheduleConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CronScheduleConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CronScheduleConfiguration).Name}");
                cron = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::G.ScheduleConfiguration(
                interval,

                cron
                );

            if (interval != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.IntervalScheduleConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.IntervalScheduleConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.IntervalScheduleConfiguration).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (cron != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CronScheduleConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CronScheduleConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CronScheduleConfiguration).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ScheduleConfiguration value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInterval)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.IntervalScheduleConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.IntervalScheduleConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.IntervalScheduleConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Interval, typeInfo);
            }
            else if (value.IsCron)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CronScheduleConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CronScheduleConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CronScheduleConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cron, typeInfo);
            }
        }
    }
}