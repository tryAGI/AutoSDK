//HintName: G.JsonConverters.RequestClickhouseFilterNode.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class RequestClickhouseFilterNodeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RequestClickhouseFilterNode>
    {
        /// <inheritdoc />
        public override global::G.RequestClickhouseFilterNode Read(
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
            if (__jsonProps.Contains("request_response_rmt")) __score0++;
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

            global::G.PickFilterLeafRequestResponseRmt? value1 = default;
            global::G.RequestClickhouseFilterBranch? value2 = default;
            global::G.RequestClickhouseFilterNodeEnum? value3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PickFilterLeafRequestResponseRmt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PickFilterLeafRequestResponseRmt> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PickFilterLeafRequestResponseRmt).Name}");
                        value1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestClickhouseFilterBranch), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestClickhouseFilterBranch> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestClickhouseFilterBranch).Name}");
                        value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestClickhouseFilterNodeEnum), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestClickhouseFilterNodeEnum> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestClickhouseFilterNodeEnum).Name}");
                        value3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (value1 == null && value2 == null && value3 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PickFilterLeafRequestResponseRmt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PickFilterLeafRequestResponseRmt> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PickFilterLeafRequestResponseRmt).Name}");
                    value1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestClickhouseFilterBranch), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestClickhouseFilterBranch> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestClickhouseFilterBranch).Name}");
                    value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestClickhouseFilterNodeEnum), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestClickhouseFilterNodeEnum> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestClickhouseFilterNodeEnum).Name}");
                    value3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.RequestClickhouseFilterNode(
                value1,

                value2,

                value3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RequestClickhouseFilterNode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PickFilterLeafRequestResponseRmt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PickFilterLeafRequestResponseRmt?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PickFilterLeafRequestResponseRmt).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1!, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestClickhouseFilterBranch), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestClickhouseFilterBranch?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestClickhouseFilterBranch).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2!, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestClickhouseFilterNodeEnum), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestClickhouseFilterNodeEnum> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestClickhouseFilterNodeEnum).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3!.Value, typeInfo);
            }
        }
    }
}