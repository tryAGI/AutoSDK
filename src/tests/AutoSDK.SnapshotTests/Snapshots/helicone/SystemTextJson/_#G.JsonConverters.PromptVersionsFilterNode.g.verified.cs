//HintName: G.JsonConverters.PromptVersionsFilterNode.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class PromptVersionsFilterNodeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PromptVersionsFilterNode>
    {
        /// <inheritdoc />
        public override global::G.PromptVersionsFilterNode Read(
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
            if (__jsonProps.Contains("prompts_versions")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("left")) __score1++;
            if (__jsonProps.Contains("operator")) __score1++;
            if (__jsonProps.Contains("right")) __score1++;
            var __score2 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.PickFilterLeafPromptsVersions? pickLeafPrompts = default;
            global::G.PromptVersionsFilterBranch? branch = default;
            global::G.PromptVersionsFilterNodeEnum? @enum = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        pickLeafPrompts = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PickFilterLeafPromptsVersions>(__rawJson, options);
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
                        branch = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PromptVersionsFilterBranch>(__rawJson, options);
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
                        @enum = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PromptVersionsFilterNodeEnum>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (pickLeafPrompts == null && branch == null && @enum == null)
            {
                try
                {
                    pickLeafPrompts = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PickFilterLeafPromptsVersions>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    branch = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PromptVersionsFilterBranch>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    @enum = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PromptVersionsFilterNodeEnum>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.PromptVersionsFilterNode(
                pickLeafPrompts,

                branch,

                @enum
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PromptVersionsFilterNode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsPickLeafPrompts)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLeafPrompts, typeof(global::G.PickFilterLeafPromptsVersions), options);
            }
            else if (value.IsBranch)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Branch, typeof(global::G.PromptVersionsFilterBranch), options);
            }
            else if (value.IsEnum)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Enum, typeof(global::G.PromptVersionsFilterNodeEnum), options);
            }
        }
    }
}