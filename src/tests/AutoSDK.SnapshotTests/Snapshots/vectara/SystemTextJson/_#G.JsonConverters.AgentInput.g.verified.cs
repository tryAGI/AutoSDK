//HintName: G.JsonConverters.AgentInput.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AgentInputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AgentInput>
    {
        /// <inheritdoc />
        public override global::G.AgentInput Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentInputDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentInputDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AgentInputDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.AgentTextInput? text = default;
            if (discriminator?.Type == global::G.AgentInputDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentTextInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentTextInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AgentTextInput)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AgentSkillInput? skill = default;
            if (discriminator?.Type == global::G.AgentInputDiscriminatorType.Skill)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentSkillInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentSkillInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AgentSkillInput)}");
                skill = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.AgentInput(
                discriminator?.Type,
                text,

                skill
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AgentInput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentTextInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentTextInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentTextInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsSkill)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentSkillInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentSkillInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentSkillInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Skill!, typeInfo);
            }
        }
    }
}