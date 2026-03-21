//HintName: G.JsonConverters.GetTasksResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class GetTasksResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetTasksResponse>
    {
        /// <inheritdoc />
        public override global::G.GetTasksResponse Read(
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
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("createdAt")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("createdAt")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("createdAt")) __score2++;
            if (__jsonProps.Contains("status")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("createdAt")) __score3++;
            if (__jsonProps.Contains("status")) __score3++;
            if (__jsonProps.Contains("progress")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("createdAt")) __score4++;
            if (__jsonProps.Contains("status")) __score4++;
            if (__jsonProps.Contains("failure")) __score4++;
            if (__jsonProps.Contains("failureCode")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("createdAt")) __score5++;
            if (__jsonProps.Contains("status")) __score5++;
            if (__jsonProps.Contains("output")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::G.GetTasksResponseVariant1? pending = default;
            global::G.GetTasksResponseVariant2? throttled = default;
            global::G.GetTasksResponseVariant3? cancelled = default;
            global::G.GetTasksResponseVariant4? running = default;
            global::G.GetTasksResponseVariant5? failed = default;
            global::G.GetTasksResponseVariant6? succeeded = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetTasksResponseVariant1).Name}");
                        pending = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetTasksResponseVariant2).Name}");
                        throttled = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetTasksResponseVariant3).Name}");
                        cancelled = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetTasksResponseVariant4).Name}");
                        running = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetTasksResponseVariant5).Name}");
                        failed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetTasksResponseVariant6).Name}");
                        succeeded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (pending == null && throttled == null && cancelled == null && running == null && failed == null && succeeded == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetTasksResponseVariant1).Name}");
                    pending = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetTasksResponseVariant2).Name}");
                    throttled = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetTasksResponseVariant3).Name}");
                    cancelled = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetTasksResponseVariant4).Name}");
                    running = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetTasksResponseVariant5).Name}");
                    failed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetTasksResponseVariant6).Name}");
                    succeeded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.GetTasksResponse(
                pending,

                throttled,

                cancelled,

                running,

                failed,

                succeeded
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetTasksResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPending)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetTasksResponseVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pending, typeInfo);
            }
            else if (value.IsThrottled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetTasksResponseVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Throttled, typeInfo);
            }
            else if (value.IsCancelled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetTasksResponseVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cancelled, typeInfo);
            }
            else if (value.IsRunning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetTasksResponseVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Running, typeInfo);
            }
            else if (value.IsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetTasksResponseVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Failed, typeInfo);
            }
            else if (value.IsSucceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetTasksResponseVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetTasksResponseVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetTasksResponseVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Succeeded, typeInfo);
            }
        }
    }
}