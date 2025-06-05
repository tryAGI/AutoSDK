//HintName: G.JsonConverters.JobsApiRoutesFineTuningUpdateFineTunedModelResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class JobsApiRoutesFineTuningUpdateFineTunedModelResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.JobsApiRoutesFineTuningUpdateFineTunedModelResponse>
    {
        /// <inheritdoc />
        public override global::G.JobsApiRoutesFineTuningUpdateFineTunedModelResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CompletionFTModelOut? completion = default;
            if (discriminator?.ModelType == global::G.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelType.Completion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompletionFTModelOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompletionFTModelOut> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CompletionFTModelOut)}");
                completion = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ClassifierFTModelOut? classifier = default;
            if (discriminator?.ModelType == global::G.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelType.Classifier)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ClassifierFTModelOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ClassifierFTModelOut> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ClassifierFTModelOut)}");
                classifier = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.JobsApiRoutesFineTuningUpdateFineTunedModelResponse(
                discriminator?.ModelType,
                completion,
                classifier
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.JobsApiRoutesFineTuningUpdateFineTunedModelResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCompletion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompletionFTModelOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompletionFTModelOut?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CompletionFTModelOut).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Completion, typeInfo);
            }
            else if (value.IsClassifier)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ClassifierFTModelOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ClassifierFTModelOut?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ClassifierFTModelOut).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Classifier, typeInfo);
            }
        }
    }
}