//HintName: G.JsonConverters.ToolsItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ToolsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ToolsItem>
    {
        /// <inheritdoc />
        public override global::G.ToolsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ConvAIStoredSecretDependenciesToolDiscriminator>(ref readerCopy, options);

            global::G.DependentAvailableToolIdentifier? available = default;
            if (discriminator?.Type == global::G.ConvAIStoredSecretDependenciesToolDiscriminatorType.Available)
            {
                available = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DependentAvailableToolIdentifier>(ref reader, options);
            }
            global::G.DependentUnknownToolIdentifier? unknown = default;
            if (discriminator?.Type == global::G.ConvAIStoredSecretDependenciesToolDiscriminatorType.Unknown)
            {
                unknown = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DependentUnknownToolIdentifier>(ref reader, options);
            }

            var __value = new global::G.ToolsItem(
                discriminator?.Type,
                available,

                unknown
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ToolsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsAvailable)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Available, typeof(global::G.DependentAvailableToolIdentifier), options);
            }
            else if (value.IsUnknown)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unknown, typeof(global::G.DependentUnknownToolIdentifier), options);
            }
        }
    }
}