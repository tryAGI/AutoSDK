//HintName: JsonConverters.ToolsItem.g.cs
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaCountMessageTokensParamsToolDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaCountMessageTokensParamsToolDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaCountMessageTokensParamsToolDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.BetaTool? custom = default;
            if (discriminator?.Type == global::G.BetaCountMessageTokensParamsToolDiscriminatorType.Custom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaTool)}");
                custom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BetaComputerUseTool20241022? computer20241022 = default;
            if (discriminator?.Type == global::G.BetaCountMessageTokensParamsToolDiscriminatorType.Computer20241022)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaComputerUseTool20241022), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaComputerUseTool20241022> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaComputerUseTool20241022)}");
                computer20241022 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BetaBashTool20241022? bash20241022 = default;
            if (discriminator?.Type == global::G.BetaCountMessageTokensParamsToolDiscriminatorType.Bash20241022)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaBashTool20241022), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaBashTool20241022> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaBashTool20241022)}");
                bash20241022 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BetaTextEditor20241022? textEditor20241022 = default;
            if (discriminator?.Type == global::G.BetaCountMessageTokensParamsToolDiscriminatorType.TextEditor20241022)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaTextEditor20241022), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaTextEditor20241022> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaTextEditor20241022)}");
                textEditor20241022 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.ToolsItem(
                discriminator?.Type,
                custom,
                computer20241022,
                bash20241022,
                textEditor20241022
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ToolsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom, typeInfo);
            }
            else if (value.IsComputer20241022)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaComputerUseTool20241022), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaComputerUseTool20241022?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaComputerUseTool20241022).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Computer20241022, typeInfo);
            }
            else if (value.IsBash20241022)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaBashTool20241022), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaBashTool20241022?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaBashTool20241022).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bash20241022, typeInfo);
            }
            else if (value.IsTextEditor20241022)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaTextEditor20241022), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaTextEditor20241022?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaTextEditor20241022).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditor20241022, typeInfo);
            }
        }
    }
}