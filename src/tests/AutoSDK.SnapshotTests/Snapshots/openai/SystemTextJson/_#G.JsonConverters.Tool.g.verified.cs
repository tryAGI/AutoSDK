//HintName: G.JsonConverters.Tool.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ToolJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Tool>
    {
        /// <inheritdoc />
        public override global::G.Tool Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("parameters")) __score0++;
            if (__jsonProps.Contains("strict")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("filters")) __score1++;
            if (__jsonProps.Contains("max_num_results")) __score1++;
            if (__jsonProps.Contains("ranking_options")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("vector_store_ids")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("search_context_size")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("user_location")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("display_height")) __score3++;
            if (__jsonProps.Contains("display_width")) __score3++;
            if (__jsonProps.Contains("environment")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("allowed_tools")) __score4++;
            if (__jsonProps.Contains("headers")) __score4++;
            if (__jsonProps.Contains("require_approval")) __score4++;
            if (__jsonProps.Contains("server_label")) __score4++;
            if (__jsonProps.Contains("server_url")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("container")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("background")) __score6++;
            if (__jsonProps.Contains("input_image_mask")) __score6++;
            if (__jsonProps.Contains("model")) __score6++;
            if (__jsonProps.Contains("moderation")) __score6++;
            if (__jsonProps.Contains("output_compression")) __score6++;
            if (__jsonProps.Contains("output_format")) __score6++;
            if (__jsonProps.Contains("partial_images")) __score6++;
            if (__jsonProps.Contains("quality")) __score6++;
            if (__jsonProps.Contains("size")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("type")) __score7++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }

            global::G.FunctionTool? function = default;
            global::G.FileSearchTool? fileSearch = default;
            global::G.WebSearchPreviewTool? webSearchPreview = default;
            global::G.ComputerUsePreviewTool? computerUsePreview = default;
            global::G.MCPTool? mcp = default;
            global::G.CodeInterpreterTool? codeInterpreter = default;
            global::G.ImageGenTool? imageGeneration = default;
            global::G.LocalShellTool? localShell = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionTool).Name}");
                        function = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileSearchTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FileSearchTool).Name}");
                        fileSearch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSearchPreviewTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSearchPreviewTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSearchPreviewTool).Name}");
                        webSearchPreview = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComputerUsePreviewTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComputerUsePreviewTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ComputerUsePreviewTool).Name}");
                        computerUsePreview = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MCPTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MCPTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MCPTool).Name}");
                        mcp = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeInterpreterTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeInterpreterTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CodeInterpreterTool).Name}");
                        codeInterpreter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageGenTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageGenTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageGenTool).Name}");
                        imageGeneration = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalShellTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LocalShellTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LocalShellTool).Name}");
                        localShell = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (function == null && fileSearch == null && webSearchPreview == null && computerUsePreview == null && mcp == null && codeInterpreter == null && imageGeneration == null && localShell == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionTool).Name}");
                    function = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileSearchTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FileSearchTool).Name}");
                    fileSearch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSearchPreviewTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSearchPreviewTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSearchPreviewTool).Name}");
                    webSearchPreview = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComputerUsePreviewTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComputerUsePreviewTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ComputerUsePreviewTool).Name}");
                    computerUsePreview = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MCPTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MCPTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MCPTool).Name}");
                    mcp = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeInterpreterTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeInterpreterTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CodeInterpreterTool).Name}");
                    codeInterpreter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageGenTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageGenTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageGenTool).Name}");
                    imageGeneration = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalShellTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LocalShellTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LocalShellTool).Name}");
                    localShell = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.Tool(
                function,

                fileSearch,

                webSearchPreview,

                computerUsePreview,

                mcp,

                codeInterpreter,

                imageGeneration,

                localShell
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Tool value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function!, typeInfo);
            }
            else if (value.IsFileSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileSearchTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FileSearchTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearch!, typeInfo);
            }
            else if (value.IsWebSearchPreview)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSearchPreviewTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSearchPreviewTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSearchPreviewTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchPreview!, typeInfo);
            }
            else if (value.IsComputerUsePreview)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComputerUsePreviewTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComputerUsePreviewTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ComputerUsePreviewTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerUsePreview!, typeInfo);
            }
            else if (value.IsMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MCPTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MCPTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MCPTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp!, typeInfo);
            }
            else if (value.IsCodeInterpreter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeInterpreterTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeInterpreterTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CodeInterpreterTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreter!, typeInfo);
            }
            else if (value.IsImageGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageGenTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageGenTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageGenTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageGeneration!, typeInfo);
            }
            else if (value.IsLocalShell)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalShellTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LocalShellTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LocalShellTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LocalShell!, typeInfo);
            }
        }
    }
}