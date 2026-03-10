//HintName: G.JsonConverters.EvalGraderScoreModel.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class EvalGraderScoreModelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EvalGraderScoreModel>
    {
        /// <inheritdoc />
        public override global::G.EvalGraderScoreModel Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.GraderScoreModel? scoreModelGrader = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GraderScoreModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GraderScoreModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GraderScoreModel).Name}");
                scoreModelGrader = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.EvalGraderScoreModelVariant2? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EvalGraderScoreModelVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EvalGraderScoreModelVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EvalGraderScoreModelVariant2).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::G.EvalGraderScoreModel(
                scoreModelGrader,

                value2
                );

            if (scoreModelGrader != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GraderScoreModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GraderScoreModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GraderScoreModel).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EvalGraderScoreModelVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EvalGraderScoreModelVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EvalGraderScoreModelVariant2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EvalGraderScoreModel value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsScoreModelGrader)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GraderScoreModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GraderScoreModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GraderScoreModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ScoreModelGrader, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EvalGraderScoreModelVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EvalGraderScoreModelVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EvalGraderScoreModelVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
        }
    }
}