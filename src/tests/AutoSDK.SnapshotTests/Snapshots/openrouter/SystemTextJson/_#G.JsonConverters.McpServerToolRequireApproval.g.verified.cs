//HintName: G.JsonConverters.McpServerToolRequireApproval.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class McpServerToolRequireApprovalJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.McpServerToolRequireApproval>
    {
        /// <inheritdoc />
        public override global::G.McpServerToolRequireApproval Read(
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
            if (__jsonProps.Contains("always")) __score0++;
            if (__jsonProps.Contains("never")) __score0++;
            var __score1 = 0;
            var __score2 = 0;
            var __score3 = 0;
            var __score4 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::G.McpServerToolRequireApproval0? mcpServerToolRequireApproval0 = default;
            global::G.McpServerToolRequireApproval1? mcpServerToolRequireApproval1 = default;
            global::G.McpServerToolRequireApproval2? mcpServerToolRequireApproval2 = default;
            object? value4 = default;
            object? value5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.McpServerToolRequireApproval0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.McpServerToolRequireApproval0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.McpServerToolRequireApproval0).Name}");
                        mcpServerToolRequireApproval0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.McpServerToolRequireApproval1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.McpServerToolRequireApproval1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.McpServerToolRequireApproval1).Name}");
                        mcpServerToolRequireApproval1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.McpServerToolRequireApproval2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.McpServerToolRequireApproval2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.McpServerToolRequireApproval2).Name}");
                        mcpServerToolRequireApproval2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                        value4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                        value5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (mcpServerToolRequireApproval0 == null && mcpServerToolRequireApproval1 == null && mcpServerToolRequireApproval2 == null && value4 == null && value5 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.McpServerToolRequireApproval0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.McpServerToolRequireApproval0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.McpServerToolRequireApproval0).Name}");
                    mcpServerToolRequireApproval0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.McpServerToolRequireApproval1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.McpServerToolRequireApproval1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.McpServerToolRequireApproval1).Name}");
                    mcpServerToolRequireApproval1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.McpServerToolRequireApproval2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.McpServerToolRequireApproval2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.McpServerToolRequireApproval2).Name}");
                    mcpServerToolRequireApproval2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                    value4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                    value5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.McpServerToolRequireApproval(
                mcpServerToolRequireApproval0,

                mcpServerToolRequireApproval1,

                mcpServerToolRequireApproval2,

                value4,

                value5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.McpServerToolRequireApproval value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMcpServerToolRequireApproval0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.McpServerToolRequireApproval0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.McpServerToolRequireApproval0?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.McpServerToolRequireApproval0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpServerToolRequireApproval0!, typeInfo);
            }
            else if (value.IsMcpServerToolRequireApproval1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.McpServerToolRequireApproval1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.McpServerToolRequireApproval1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.McpServerToolRequireApproval1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpServerToolRequireApproval1!.Value, typeInfo);
            }
            else if (value.IsMcpServerToolRequireApproval2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.McpServerToolRequireApproval2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.McpServerToolRequireApproval2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.McpServerToolRequireApproval2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpServerToolRequireApproval2!.Value, typeInfo);
            }
            else if (value.IsValue4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4!, typeInfo);
            }
            else if (value.IsValue5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value5!, typeInfo);
            }
        }
    }
}