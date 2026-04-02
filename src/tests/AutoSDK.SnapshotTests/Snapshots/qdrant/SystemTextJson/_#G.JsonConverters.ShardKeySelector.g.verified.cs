//HintName: G.JsonConverters.ShardKeySelector.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ShardKeySelectorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ShardKeySelector>
    {
        /// <inheritdoc />
        public override global::G.ShardKeySelector Read(
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
            var __score1 = 0;
            var __score2 = 0;
            if (__jsonProps.Contains("fallback")) __score2++;
            if (__jsonProps.Contains("target")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.ShardKey? shardKey = default;
            global::System.Collections.Generic.IList<global::G.ShardKey>? shardKeySelectorVariant2 = default;
            global::G.ShardKeyWithFallback? withFallback = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShardKey), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShardKey> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ShardKey).Name}");
                        shardKey = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::G.ShardKey>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::G.ShardKey>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::G.ShardKey>).Name}");
                        shardKeySelectorVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShardKeyWithFallback), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShardKeyWithFallback> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ShardKeyWithFallback).Name}");
                        withFallback = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (shardKey == null && shardKeySelectorVariant2 == null && withFallback == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShardKey), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShardKey> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ShardKey).Name}");
                    shardKey = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::G.ShardKey>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::G.ShardKey>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::G.ShardKey>).Name}");
                    shardKeySelectorVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShardKeyWithFallback), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShardKeyWithFallback> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ShardKeyWithFallback).Name}");
                    withFallback = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ShardKeySelector(
                shardKey,

                shardKeySelectorVariant2,

                withFallback
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ShardKeySelector value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsShardKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShardKey), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShardKey> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ShardKey).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ShardKey!.Value, typeInfo);
            }
            else if (value.IsShardKeySelectorVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::G.ShardKey>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::G.ShardKey>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::G.ShardKey>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ShardKeySelectorVariant2!, typeInfo);
            }
            else if (value.IsWithFallback)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShardKeyWithFallback), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShardKeyWithFallback?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ShardKeyWithFallback).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WithFallback!, typeInfo);
            }
        }
    }
}