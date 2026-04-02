//HintName: G.JsonConverters.PromptTemplate5.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class PromptTemplate5JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PromptTemplate5>
    {
        /// <inheritdoc />
        public override global::G.PromptTemplate5 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PromptBlueprintPromptTemplateDiscriminator>(ref readerCopy, options);

            global::G.CompletionPrompt? completion = default;
            if (discriminator?.Type == global::G.PromptBlueprintPromptTemplateDiscriminatorType.Completion)
            {
                completion = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CompletionPrompt>(ref reader, options);
            }
            global::G.ChatPrompt? chat = default;
            if (discriminator?.Type == global::G.PromptBlueprintPromptTemplateDiscriminatorType.Chat)
            {
                chat = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatPrompt>(ref reader, options);
            }

            var __value = new global::G.PromptTemplate5(
                discriminator?.Type,
                completion,

                chat
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PromptTemplate5 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsCompletion)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Completion, typeof(global::G.CompletionPrompt), options);
            }
            else if (value.IsChat)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chat, typeof(global::G.ChatPrompt), options);
            }
        }
    }
}