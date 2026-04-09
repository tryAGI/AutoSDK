//HintName: G.JsonConverters.TopicAutomationDataScope.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class TopicAutomationDataScopeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TopicAutomationDataScope>
    {
        /// <inheritdoc />
        public override global::G.TopicAutomationDataScope Read(
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
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("experiment_id")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::G.TopicAutomationDataScopeVariant1? topicAutomationDataScopeVariant1 = default;
            global::G.TopicAutomationDataScopeVariant2? topicAutomationDataScopeVariant2 = default;
            global::G.TopicAutomationDataScopeVariant3? topicAutomationDataScopeVariant3 = default;
            object? topicAutomationDataScopeVariant4 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TopicAutomationDataScopeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TopicAutomationDataScopeVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TopicAutomationDataScopeVariant1).Name}");
                        topicAutomationDataScopeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TopicAutomationDataScopeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TopicAutomationDataScopeVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TopicAutomationDataScopeVariant2).Name}");
                        topicAutomationDataScopeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TopicAutomationDataScopeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TopicAutomationDataScopeVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TopicAutomationDataScopeVariant3).Name}");
                        topicAutomationDataScopeVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        topicAutomationDataScopeVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (topicAutomationDataScopeVariant1 == null && topicAutomationDataScopeVariant2 == null && topicAutomationDataScopeVariant3 == null && topicAutomationDataScopeVariant4 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TopicAutomationDataScopeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TopicAutomationDataScopeVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TopicAutomationDataScopeVariant1).Name}");
                    topicAutomationDataScopeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TopicAutomationDataScopeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TopicAutomationDataScopeVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TopicAutomationDataScopeVariant2).Name}");
                    topicAutomationDataScopeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TopicAutomationDataScopeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TopicAutomationDataScopeVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TopicAutomationDataScopeVariant3).Name}");
                    topicAutomationDataScopeVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                    topicAutomationDataScopeVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.TopicAutomationDataScope(
                topicAutomationDataScopeVariant1,

                topicAutomationDataScopeVariant2,

                topicAutomationDataScopeVariant3,

                topicAutomationDataScopeVariant4
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TopicAutomationDataScope value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTopicAutomationDataScopeVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TopicAutomationDataScopeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TopicAutomationDataScopeVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TopicAutomationDataScopeVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TopicAutomationDataScopeVariant1!, typeInfo);
            }
            else if (value.IsTopicAutomationDataScopeVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TopicAutomationDataScopeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TopicAutomationDataScopeVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TopicAutomationDataScopeVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TopicAutomationDataScopeVariant2!, typeInfo);
            }
            else if (value.IsTopicAutomationDataScopeVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TopicAutomationDataScopeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TopicAutomationDataScopeVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TopicAutomationDataScopeVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TopicAutomationDataScopeVariant3!, typeInfo);
            }
            else if (value.IsTopicAutomationDataScopeVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TopicAutomationDataScopeVariant4!, typeInfo);
            }
        }
    }
}