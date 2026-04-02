//HintName: G.JsonConverters.RunStreamEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class RunStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RunStreamEvent>
    {
        /// <inheritdoc />
        public override global::G.RunStreamEvent Read(
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
            if (__jsonProps.Contains("data")) __score0++;
            if (__jsonProps.Contains("event")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("data")) __score1++;
            if (__jsonProps.Contains("event")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("data")) __score2++;
            if (__jsonProps.Contains("event")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("data")) __score3++;
            if (__jsonProps.Contains("event")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("data")) __score4++;
            if (__jsonProps.Contains("event")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("data")) __score5++;
            if (__jsonProps.Contains("event")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("data")) __score6++;
            if (__jsonProps.Contains("event")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("data")) __score7++;
            if (__jsonProps.Contains("event")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("data")) __score8++;
            if (__jsonProps.Contains("event")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("data")) __score9++;
            if (__jsonProps.Contains("event")) __score9++;
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

            global::G.RunStreamEventVariant1? runStreamEventVariant1 = default;
            global::G.RunStreamEventVariant2? runStreamEventVariant2 = default;
            global::G.RunStreamEventVariant3? runStreamEventVariant3 = default;
            global::G.RunStreamEventVariant4? runStreamEventVariant4 = default;
            global::G.RunStreamEventVariant5? runStreamEventVariant5 = default;
            global::G.RunStreamEventVariant6? runStreamEventVariant6 = default;
            global::G.RunStreamEventVariant7? runStreamEventVariant7 = default;
            global::G.RunStreamEventVariant8? runStreamEventVariant8 = default;
            global::G.RunStreamEventVariant9? runStreamEventVariant9 = default;
            global::G.RunStreamEventVariant10? runStreamEventVariant10 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant1).Name}");
                        runStreamEventVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant2).Name}");
                        runStreamEventVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant3).Name}");
                        runStreamEventVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant4).Name}");
                        runStreamEventVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant5).Name}");
                        runStreamEventVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant6).Name}");
                        runStreamEventVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant7).Name}");
                        runStreamEventVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant8).Name}");
                        runStreamEventVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant9> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant9).Name}");
                        runStreamEventVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant10> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant10).Name}");
                        runStreamEventVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (runStreamEventVariant1 == null && runStreamEventVariant2 == null && runStreamEventVariant3 == null && runStreamEventVariant4 == null && runStreamEventVariant5 == null && runStreamEventVariant6 == null && runStreamEventVariant7 == null && runStreamEventVariant8 == null && runStreamEventVariant9 == null && runStreamEventVariant10 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant1).Name}");
                    runStreamEventVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant2).Name}");
                    runStreamEventVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant3).Name}");
                    runStreamEventVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant4).Name}");
                    runStreamEventVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant5).Name}");
                    runStreamEventVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant6).Name}");
                    runStreamEventVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant7).Name}");
                    runStreamEventVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant8).Name}");
                    runStreamEventVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant9> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant9).Name}");
                    runStreamEventVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant10> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant10).Name}");
                    runStreamEventVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.RunStreamEvent(
                runStreamEventVariant1,

                runStreamEventVariant2,

                runStreamEventVariant3,

                runStreamEventVariant4,

                runStreamEventVariant5,

                runStreamEventVariant6,

                runStreamEventVariant7,

                runStreamEventVariant8,

                runStreamEventVariant9,

                runStreamEventVariant10
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RunStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRunStreamEventVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant1!, typeInfo);
            }
            else if (value.IsRunStreamEventVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant2!, typeInfo);
            }
            else if (value.IsRunStreamEventVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant3!, typeInfo);
            }
            else if (value.IsRunStreamEventVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant4!, typeInfo);
            }
            else if (value.IsRunStreamEventVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant5!, typeInfo);
            }
            else if (value.IsRunStreamEventVariant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant6!, typeInfo);
            }
            else if (value.IsRunStreamEventVariant7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant7!, typeInfo);
            }
            else if (value.IsRunStreamEventVariant8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant8!, typeInfo);
            }
            else if (value.IsRunStreamEventVariant9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant9?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant9!, typeInfo);
            }
            else if (value.IsRunStreamEventVariant10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant10?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant10!, typeInfo);
            }
        }
    }
}