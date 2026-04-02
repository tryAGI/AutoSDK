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
                        function = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionTool>(__rawJson, options);
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
                        fileSearch = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FileSearchTool>(__rawJson, options);
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
                        webSearchPreview = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WebSearchPreviewTool>(__rawJson, options);
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
                        computerUsePreview = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ComputerUsePreviewTool>(__rawJson, options);
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
                        mcp = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MCPTool>(__rawJson, options);
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
                        codeInterpreter = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CodeInterpreterTool>(__rawJson, options);
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
                        imageGeneration = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ImageGenTool>(__rawJson, options);
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
                        localShell = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LocalShellTool>(__rawJson, options);
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
                    function = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    fileSearch = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FileSearchTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    webSearchPreview = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WebSearchPreviewTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    computerUsePreview = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ComputerUsePreviewTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mcp = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MCPTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    codeInterpreter = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CodeInterpreterTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    imageGeneration = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ImageGenTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    localShell = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LocalShellTool>(__rawJson, options);
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

            if (value.IsFunction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeof(global::G.FunctionTool), options);
            }
            else if (value.IsFileSearch)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearch, typeof(global::G.FileSearchTool), options);
            }
            else if (value.IsWebSearchPreview)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchPreview, typeof(global::G.WebSearchPreviewTool), options);
            }
            else if (value.IsComputerUsePreview)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerUsePreview, typeof(global::G.ComputerUsePreviewTool), options);
            }
            else if (value.IsMcp)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp, typeof(global::G.MCPTool), options);
            }
            else if (value.IsCodeInterpreter)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreter, typeof(global::G.CodeInterpreterTool), options);
            }
            else if (value.IsImageGeneration)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageGeneration, typeof(global::G.ImageGenTool), options);
            }
            else if (value.IsLocalShell)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LocalShell, typeof(global::G.LocalShellTool), options);
            }
        }
    }
}