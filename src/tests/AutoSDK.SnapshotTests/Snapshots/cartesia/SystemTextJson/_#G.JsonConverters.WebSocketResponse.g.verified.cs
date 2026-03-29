//HintName: G.JsonConverters.WebSocketResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class WebSocketResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebSocketResponse>
    {
        /// <inheritdoc />
        public override global::G.WebSocketResponse Read(
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
            if (__jsonProps.Contains("context_id")) __score0++;
            if (__jsonProps.Contains("data")) __score0++;
            if (__jsonProps.Contains("done")) __score0++;
            if (__jsonProps.Contains("flush_id")) __score0++;
            if (__jsonProps.Contains("status_code")) __score0++;
            if (__jsonProps.Contains("step_time")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("context_id")) __score1++;
            if (__jsonProps.Contains("done")) __score1++;
            if (__jsonProps.Contains("flush_done")) __score1++;
            if (__jsonProps.Contains("flush_id")) __score1++;
            if (__jsonProps.Contains("status_code")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("context_id")) __score2++;
            if (__jsonProps.Contains("done")) __score2++;
            if (__jsonProps.Contains("status_code")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("context_id")) __score3++;
            if (__jsonProps.Contains("done")) __score3++;
            if (__jsonProps.Contains("flush_id")) __score3++;
            if (__jsonProps.Contains("status_code")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("word_timestamps")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("context_id")) __score4++;
            if (__jsonProps.Contains("done")) __score4++;
            if (__jsonProps.Contains("error")) __score4++;
            if (__jsonProps.Contains("status_code")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("context_id")) __score5++;
            if (__jsonProps.Contains("done")) __score5++;
            if (__jsonProps.Contains("flush_id")) __score5++;
            if (__jsonProps.Contains("phoneme_timestamps")) __score5++;
            if (__jsonProps.Contains("status_code")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::G.WebSocketResponseVariant1? chunk = default;
            global::G.WebSocketResponseVariant2? flushDone = default;
            global::G.WebSocketResponseVariant3? done = default;
            global::G.WebSocketResponseVariant4? timestamps = default;
            global::G.WebSocketResponseVariant5? error = default;
            global::G.WebSocketResponseVariant6? phonemeTimestamps = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSocketResponseVariant1).Name}");
                        chunk = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSocketResponseVariant2).Name}");
                        flushDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSocketResponseVariant3).Name}");
                        done = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSocketResponseVariant4).Name}");
                        timestamps = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSocketResponseVariant5).Name}");
                        error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSocketResponseVariant6).Name}");
                        phonemeTimestamps = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (chunk == null && flushDone == null && done == null && timestamps == null && error == null && phonemeTimestamps == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSocketResponseVariant1).Name}");
                    chunk = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSocketResponseVariant2).Name}");
                    flushDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSocketResponseVariant3).Name}");
                    done = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSocketResponseVariant4).Name}");
                    timestamps = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSocketResponseVariant5).Name}");
                    error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSocketResponseVariant6).Name}");
                    phonemeTimestamps = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.WebSocketResponse(
                chunk,

                flushDone,

                done,

                timestamps,

                error,

                phonemeTimestamps
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebSocketResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSocketResponseVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chunk, typeInfo);
            }
            else if (value.IsFlushDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSocketResponseVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FlushDone, typeInfo);
            }
            else if (value.IsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSocketResponseVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Done, typeInfo);
            }
            else if (value.IsTimestamps)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSocketResponseVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Timestamps, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSocketResponseVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeInfo);
            }
            else if (value.IsPhonemeTimestamps)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSocketResponseVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSocketResponseVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSocketResponseVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PhonemeTimestamps, typeInfo);
            }
        }
    }
}