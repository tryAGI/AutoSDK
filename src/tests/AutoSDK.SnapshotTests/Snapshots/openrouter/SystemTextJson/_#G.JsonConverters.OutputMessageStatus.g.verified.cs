//HintName: G.JsonConverters.OutputMessageStatus.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class OutputMessageStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.OutputMessageStatus>
    {
        /// <inheritdoc />
        public override global::G.OutputMessageStatus Read(
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
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMessageStatus0), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score0++;
                    }
                }
            }
            var __score1 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMessageStatus1), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score1++;
                    }
                }
            }
            var __score2 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMessageStatus2), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score2++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.OutputMessageStatus0? outputMessageStatus0 = default;
            global::G.OutputMessageStatus1? outputMessageStatus1 = default;
            global::G.OutputMessageStatus2? outputMessageStatus2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMessageStatus0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputMessageStatus0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputMessageStatus0).Name}");
                        outputMessageStatus0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMessageStatus1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputMessageStatus1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputMessageStatus1).Name}");
                        outputMessageStatus1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMessageStatus2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputMessageStatus2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputMessageStatus2).Name}");
                        outputMessageStatus2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (outputMessageStatus0 == null && outputMessageStatus1 == null && outputMessageStatus2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMessageStatus0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputMessageStatus0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputMessageStatus0).Name}");
                    outputMessageStatus0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMessageStatus1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputMessageStatus1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputMessageStatus1).Name}");
                    outputMessageStatus1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMessageStatus2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputMessageStatus2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputMessageStatus2).Name}");
                    outputMessageStatus2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.OutputMessageStatus(
                outputMessageStatus0,

                outputMessageStatus1,

                outputMessageStatus2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OutputMessageStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOutputMessageStatus0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMessageStatus0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputMessageStatus0> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputMessageStatus0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputMessageStatus0, typeInfo);
            }
            else if (value.IsOutputMessageStatus1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMessageStatus1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputMessageStatus1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputMessageStatus1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputMessageStatus1, typeInfo);
            }
            else if (value.IsOutputMessageStatus2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMessageStatus2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputMessageStatus2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputMessageStatus2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputMessageStatus2, typeInfo);
            }
        }
    }
}