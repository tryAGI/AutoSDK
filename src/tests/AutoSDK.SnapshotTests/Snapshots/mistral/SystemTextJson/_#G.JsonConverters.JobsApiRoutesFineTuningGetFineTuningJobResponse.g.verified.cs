//HintName: G.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class JobsApiRoutesFineTuningGetFineTuningJobResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.JobsApiRoutesFineTuningGetFineTuningJobResponse>
    {
        /// <inheritdoc />
        public override global::G.JobsApiRoutesFineTuningGetFineTuningJobResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CompletionDetailedJobOut? completion = default;
            if (discriminator?.JobType == global::G.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType.Completion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompletionDetailedJobOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompletionDetailedJobOut> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CompletionDetailedJobOut)}");
                completion = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ClassifierDetailedJobOut? classifier = default;
            if (discriminator?.JobType == global::G.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType.Classifier)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ClassifierDetailedJobOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ClassifierDetailedJobOut> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ClassifierDetailedJobOut)}");
                classifier = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.JobsApiRoutesFineTuningGetFineTuningJobResponse(
                discriminator?.JobType,
                completion,
                classifier
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.JobsApiRoutesFineTuningGetFineTuningJobResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCompletion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompletionDetailedJobOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompletionDetailedJobOut?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CompletionDetailedJobOut).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Completion, typeInfo);
            }
            else if (value.IsClassifier)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ClassifierDetailedJobOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ClassifierDetailedJobOut?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ClassifierDetailedJobOut).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Classifier, typeInfo);
            }
        }
    }
}