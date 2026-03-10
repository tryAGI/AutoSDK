//HintName: G.JsonConverters.BackupLlmConfig2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BackupLlmConfig2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BackupLlmConfig2>
    {
        /// <inheritdoc />
        public override global::G.BackupLlmConfig2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptAgentAPIModelOutputBackupLlmConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptAgentAPIModelOutputBackupLlmConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptAgentAPIModelOutputBackupLlmConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.BackupLLMDefault? @default = default;
            if (discriminator?.Preference == global::G.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference.Default)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BackupLLMDefault), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BackupLLMDefault> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BackupLLMDefault)}");
                @default = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BackupLLMDisabled? disabled = default;
            if (discriminator?.Preference == global::G.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference.Disabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BackupLLMDisabled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BackupLLMDisabled> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BackupLLMDisabled)}");
                disabled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BackupLLMOverride? @override = default;
            if (discriminator?.Preference == global::G.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference.Override)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BackupLLMOverride), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BackupLLMOverride> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BackupLLMOverride)}");
                @override = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.BackupLlmConfig2(
                discriminator?.Preference,
                @default,

                disabled,

                @override
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BackupLlmConfig2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDefault)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BackupLLMDefault), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BackupLLMDefault?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BackupLLMDefault).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Default, typeInfo);
            }
            else if (value.IsDisabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BackupLLMDisabled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BackupLLMDisabled?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BackupLLMDisabled).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Disabled, typeInfo);
            }
            else if (value.IsOverride)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BackupLLMOverride), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BackupLLMOverride?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BackupLLMOverride).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Override, typeInfo);
            }
        }
    }
}