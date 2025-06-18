//HintName: G.JsonConverters.EvalGraderLabelModel.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class EvalGraderLabelModelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EvalGraderLabelModel>
    {
        /// <inheritdoc />
        public override global::G.EvalGraderLabelModel Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.GraderLabelModel? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GraderLabelModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GraderLabelModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GraderLabelModel).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.EvalGraderLabelModel(
                value1
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GraderLabelModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GraderLabelModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GraderLabelModel).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EvalGraderLabelModel value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GraderLabelModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GraderLabelModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GraderLabelModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
        }
    }
}