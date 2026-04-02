//HintName: G.JsonConverters.ResponsesRequestToolsItems.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ResponsesRequestToolsItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ResponsesRequestToolsItems>
    {
        /// <inheritdoc />
        public override global::G.ResponsesRequestToolsItems Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

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
            if (__jsonProps.Contains("engine")) __score1++;
            if (__jsonProps.Contains("filters")) __score1++;
            if (__jsonProps.Contains("max_results")) __score1++;
            if (__jsonProps.Contains("search_context_size")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("user_location")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("engine")) __score2++;
            if (__jsonProps.Contains("filters")) __score2++;
            if (__jsonProps.Contains("max_results")) __score2++;
            if (__jsonProps.Contains("search_context_size")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("user_location")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("engine")) __score3++;
            if (__jsonProps.Contains("filters")) __score3++;
            if (__jsonProps.Contains("max_results")) __score3++;
            if (__jsonProps.Contains("search_context_size")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("user_location")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("engine")) __score4++;
            if (__jsonProps.Contains("filters")) __score4++;
            if (__jsonProps.Contains("max_results")) __score4++;
            if (__jsonProps.Contains("search_context_size")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("user_location")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("filters")) __score5++;
            if (__jsonProps.Contains("max_num_results")) __score5++;
            if (__jsonProps.Contains("ranking_options")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            if (__jsonProps.Contains("vector_store_ids")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("display_height")) __score6++;
            if (__jsonProps.Contains("display_width")) __score6++;
            if (__jsonProps.Contains("environment")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("container")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("allowed_tools")) __score8++;
            if (__jsonProps.Contains("authorization")) __score8++;
            if (__jsonProps.Contains("connector_id")) __score8++;
            if (__jsonProps.Contains("headers")) __score8++;
            if (__jsonProps.Contains("require_approval")) __score8++;
            if (__jsonProps.Contains("server_description")) __score8++;
            if (__jsonProps.Contains("server_label")) __score8++;
            if (__jsonProps.Contains("server_url")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("background")) __score9++;
            if (__jsonProps.Contains("input_fidelity")) __score9++;
            if (__jsonProps.Contains("input_image_mask")) __score9++;
            if (__jsonProps.Contains("model")) __score9++;
            if (__jsonProps.Contains("moderation")) __score9++;
            if (__jsonProps.Contains("output_compression")) __score9++;
            if (__jsonProps.Contains("output_format")) __score9++;
            if (__jsonProps.Contains("partial_images")) __score9++;
            if (__jsonProps.Contains("quality")) __score9++;
            if (__jsonProps.Contains("size")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("type")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("description")) __score13++;
            if (__jsonProps.Contains("format")) __score13++;
            if (__jsonProps.Contains("name")) __score13++;
            if (__jsonProps.Contains("type")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("parameters")) __score14++;
            if (__jsonProps.Contains("type")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("parameters")) __score15++;
            if (__jsonProps.Contains("type")) __score15++;
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
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }
            if (__score13 > __bestScore) { __bestScore = __score13; __bestIndex = 13; }
            if (__score14 > __bestScore) { __bestScore = __score14; __bestIndex = 14; }
            if (__score15 > __bestScore) { __bestScore = __score15; __bestIndex = 15; }

            global::G.ResponsesRequestToolsItems0? responsesRequestToolsItems0 = default;
            global::G.PreviewWebSearchServerTool? previewWebSearchServerTool = default;
            global::G.Preview20250311WebSearchServerTool? preview20250311WebSearchServerTool = default;
            global::G.LegacyWebSearchServerTool? legacyWebSearchServerTool = default;
            global::G.WebSearchServerTool? webSearchServerTool = default;
            global::G.FileSearchServerTool? fileSearchServerTool = default;
            global::G.ComputerUseServerTool? computerUseServerTool = default;
            global::G.CodeInterpreterServerTool? codeInterpreterServerTool = default;
            global::G.McpServerTool? mcpServerTool = default;
            global::G.ImageGenerationServerTool? imageGenerationServerTool = default;
            global::G.CodexLocalShellTool? codexLocalShellTool = default;
            global::G.ShellServerTool? shellServerTool = default;
            global::G.ApplyPatchServerTool? applyPatchServerTool = default;
            global::G.CustomTool? customTool = default;
            global::G.DatetimeServerTool? datetimeServerTool = default;
            global::G.WebSearchServerToolOpenRouter? webSearchServerToolOpenRouter = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        responsesRequestToolsItems0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponsesRequestToolsItems0>(__rawJson, options);
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
                        previewWebSearchServerTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PreviewWebSearchServerTool>(__rawJson, options);
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
                        preview20250311WebSearchServerTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.Preview20250311WebSearchServerTool>(__rawJson, options);
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
                        legacyWebSearchServerTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LegacyWebSearchServerTool>(__rawJson, options);
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
                        webSearchServerTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WebSearchServerTool>(__rawJson, options);
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
                        fileSearchServerTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FileSearchServerTool>(__rawJson, options);
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
                        computerUseServerTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ComputerUseServerTool>(__rawJson, options);
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
                        codeInterpreterServerTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CodeInterpreterServerTool>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        mcpServerTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.McpServerTool>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        imageGenerationServerTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ImageGenerationServerTool>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        codexLocalShellTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CodexLocalShellTool>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        shellServerTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ShellServerTool>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 12)
                {
                    try
                    {
                        applyPatchServerTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ApplyPatchServerTool>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 13)
                {
                    try
                    {
                        customTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CustomTool>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 14)
                {
                    try
                    {
                        datetimeServerTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DatetimeServerTool>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 15)
                {
                    try
                    {
                        webSearchServerToolOpenRouter = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WebSearchServerToolOpenRouter>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (responsesRequestToolsItems0 == null && previewWebSearchServerTool == null && preview20250311WebSearchServerTool == null && legacyWebSearchServerTool == null && webSearchServerTool == null && fileSearchServerTool == null && computerUseServerTool == null && codeInterpreterServerTool == null && mcpServerTool == null && imageGenerationServerTool == null && codexLocalShellTool == null && shellServerTool == null && applyPatchServerTool == null && customTool == null && datetimeServerTool == null && webSearchServerToolOpenRouter == null)
            {
                try
                {
                    responsesRequestToolsItems0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponsesRequestToolsItems0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    previewWebSearchServerTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PreviewWebSearchServerTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    preview20250311WebSearchServerTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.Preview20250311WebSearchServerTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    legacyWebSearchServerTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LegacyWebSearchServerTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    webSearchServerTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WebSearchServerTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    fileSearchServerTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FileSearchServerTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    computerUseServerTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ComputerUseServerTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    codeInterpreterServerTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CodeInterpreterServerTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mcpServerTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.McpServerTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    imageGenerationServerTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ImageGenerationServerTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    codexLocalShellTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CodexLocalShellTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    shellServerTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ShellServerTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    applyPatchServerTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ApplyPatchServerTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    customTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CustomTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    datetimeServerTool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DatetimeServerTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    webSearchServerToolOpenRouter = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WebSearchServerToolOpenRouter>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ResponsesRequestToolsItems(
                responsesRequestToolsItems0,

                previewWebSearchServerTool,

                preview20250311WebSearchServerTool,

                legacyWebSearchServerTool,

                webSearchServerTool,

                fileSearchServerTool,

                computerUseServerTool,

                codeInterpreterServerTool,

                mcpServerTool,

                imageGenerationServerTool,

                codexLocalShellTool,

                shellServerTool,

                applyPatchServerTool,

                customTool,

                datetimeServerTool,

                webSearchServerToolOpenRouter
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ResponsesRequestToolsItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsResponsesRequestToolsItems0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponsesRequestToolsItems0, typeof(global::G.ResponsesRequestToolsItems0), options);
            }
            else if (value.IsPreviewWebSearchServerTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PreviewWebSearchServerTool, typeof(global::G.PreviewWebSearchServerTool), options);
            }
            else if (value.IsPreview20250311WebSearchServerTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Preview20250311WebSearchServerTool, typeof(global::G.Preview20250311WebSearchServerTool), options);
            }
            else if (value.IsLegacyWebSearchServerTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LegacyWebSearchServerTool, typeof(global::G.LegacyWebSearchServerTool), options);
            }
            else if (value.IsWebSearchServerTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchServerTool, typeof(global::G.WebSearchServerTool), options);
            }
            else if (value.IsFileSearchServerTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchServerTool, typeof(global::G.FileSearchServerTool), options);
            }
            else if (value.IsComputerUseServerTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerUseServerTool, typeof(global::G.ComputerUseServerTool), options);
            }
            else if (value.IsCodeInterpreterServerTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreterServerTool, typeof(global::G.CodeInterpreterServerTool), options);
            }
            else if (value.IsMcpServerTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpServerTool, typeof(global::G.McpServerTool), options);
            }
            else if (value.IsImageGenerationServerTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageGenerationServerTool, typeof(global::G.ImageGenerationServerTool), options);
            }
            else if (value.IsCodexLocalShellTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodexLocalShellTool, typeof(global::G.CodexLocalShellTool), options);
            }
            else if (value.IsShellServerTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ShellServerTool, typeof(global::G.ShellServerTool), options);
            }
            else if (value.IsApplyPatchServerTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApplyPatchServerTool, typeof(global::G.ApplyPatchServerTool), options);
            }
            else if (value.IsCustomTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomTool, typeof(global::G.CustomTool), options);
            }
            else if (value.IsDatetimeServerTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DatetimeServerTool, typeof(global::G.DatetimeServerTool), options);
            }
            else if (value.IsWebSearchServerToolOpenRouter)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchServerToolOpenRouter, typeof(global::G.WebSearchServerToolOpenRouter), options);
            }
        }
    }
}