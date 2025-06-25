//HintName: G.JsonConverters.EvalGraderStringCheck.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class EvalGraderStringCheckJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EvalGraderStringCheck>
    {
        /// <inheritdoc />
        public override global::G.EvalGraderStringCheck Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.GraderStringCheck? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GraderStringCheck), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GraderStringCheck> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GraderStringCheck).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.EvalGraderStringCheck(
                value1
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GraderStringCheck), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GraderStringCheck> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GraderStringCheck).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EvalGraderStringCheck value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GraderStringCheck), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GraderStringCheck?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GraderStringCheck).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
        }
    }
}