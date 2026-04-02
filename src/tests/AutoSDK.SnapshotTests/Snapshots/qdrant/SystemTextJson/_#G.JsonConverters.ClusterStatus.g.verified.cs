//HintName: G.JsonConverters.ClusterStatus.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ClusterStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ClusterStatus>
    {
        /// <inheritdoc />
        public override global::G.ClusterStatus Read(
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
            if (__jsonProps.Contains("status")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("consensus_thread_status")) __score1++;
            if (__jsonProps.Contains("message_send_failures")) __score1++;
            if (__jsonProps.Contains("peer_id")) __score1++;
            if (__jsonProps.Contains("peers")) __score1++;
            if (__jsonProps.Contains("raft_info")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.ClusterStatusVariant1? clusterStatusVariant1 = default;
            global::G.ClusterStatusVariant2? clusterStatusVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ClusterStatusVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ClusterStatusVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ClusterStatusVariant1).Name}");
                        clusterStatusVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ClusterStatusVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ClusterStatusVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ClusterStatusVariant2).Name}");
                        clusterStatusVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (clusterStatusVariant1 == null && clusterStatusVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ClusterStatusVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ClusterStatusVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ClusterStatusVariant1).Name}");
                    clusterStatusVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ClusterStatusVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ClusterStatusVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ClusterStatusVariant2).Name}");
                    clusterStatusVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ClusterStatus(
                clusterStatusVariant1,

                clusterStatusVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ClusterStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsClusterStatusVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ClusterStatusVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ClusterStatusVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ClusterStatusVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ClusterStatusVariant1!, typeInfo);
            }
            else if (value.IsClusterStatusVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ClusterStatusVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ClusterStatusVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ClusterStatusVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ClusterStatusVariant2!, typeInfo);
            }
        }
    }
}