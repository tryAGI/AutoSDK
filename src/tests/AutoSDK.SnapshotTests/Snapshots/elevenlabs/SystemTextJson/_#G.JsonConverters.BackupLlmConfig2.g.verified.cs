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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PromptAgentAPIModelOutputBackupLlmConfigDiscriminator>(ref readerCopy, options);

            global::G.BackupLLMDefault? @default = default;
            if (discriminator?.Preference == global::G.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference.Default)
            {
                @default = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BackupLLMDefault>(ref reader, options);
            }
            global::G.BackupLLMDisabled? disabled = default;
            if (discriminator?.Preference == global::G.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference.Disabled)
            {
                disabled = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BackupLLMDisabled>(ref reader, options);
            }
            global::G.BackupLLMOverride? @override = default;
            if (discriminator?.Preference == global::G.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference.Override)
            {
                @override = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BackupLLMOverride>(ref reader, options);
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

            if (value.IsDefault)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Default, typeof(global::G.BackupLLMDefault), options);
            }
            else if (value.IsDisabled)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Disabled, typeof(global::G.BackupLLMDisabled), options);
            }
            else if (value.IsOverride)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Override, typeof(global::G.BackupLLMOverride), options);
            }
        }
    }
}